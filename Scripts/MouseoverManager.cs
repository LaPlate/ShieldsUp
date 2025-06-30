using Godot;
using System;

public partial class MouseoverManager : Node3D
{
    Card lastHighlightedCard = new();

    public override void _Process(double delta)
    {
        Camera3D camera = GetViewport().GetCamera3D();
        if (camera == null) return;
        camera.Current = true;

        Vector2 mousePos = GetViewport().GetMousePosition();
        Vector3 origin = camera.ProjectRayOrigin(mousePos);
        Vector3 direction = camera.ProjectRayNormal(mousePos);
        var checkDistance = 1000 * direction;
        var spaceState = camera.GetWorld3D().DirectSpaceState;

        var castQuery = PhysicsRayQueryParameters3D.Create(origin, origin + checkDistance);
        var castResult = spaceState.IntersectRay(castQuery);

        //check for hit!
        if (castResult.TryGetValue("collider", out var collider) && collider.As<Node>().GetParentOrNull<Card>() is Card card)
        {
            if (card != lastHighlightedCard)
            {
                if (lastHighlightedCard != null) lastHighlightedCard.Highlight(false);
                lastHighlightedCard = card;
                lastHighlightedCard.Highlight(true);
            }
        }
        else if (lastHighlightedCard != null)
        {
            lastHighlightedCard.Highlight(false);
            lastHighlightedCard = null;
        }
    }

}
