using Godot;
using System;

public partial class MouseoverManager : Node3D
{
    Card lastHighlightedCard;

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
        if (castResult.TryGetValue("collider", out var colliderVar))
        {
            var colliderNode = colliderVar.As<Node>();
            //GD.Print("Ray hit: ", colliderNode.Name, " (type: ", colliderNode.GetType(), ")");

            var parent = colliderNode?.GetParent();
            //GD.Print("Parent: " + parent?.Name ?? "null");

            if (parent != null && parent.IsInGroup("Player_Selectable_Cards") && parent is Card card)
            {

                if (card != lastHighlightedCard)
                {
                    /*GD.Print(">>> HIGHLIGHT ATTEMPT on: ", card.Name);
                    GD.Print("    Path: ", card.GetPath());
                    GD.Print("    InsideTree: ", card.IsInsideTree());
                    GD.Print("    InstanceId: ", card.GetInstanceId());*/
                    lastHighlightedCard?.Highlight(false);
                    lastHighlightedCard = card;
                    lastHighlightedCard.Highlight(true);
                    GD.Print("Card ID: ", card.GetInstanceId());
                    GD.Print("Last highlighted: ", lastHighlightedCard?.GetInstanceId());
                }

            }
            else if (lastHighlightedCard != null)
            {
                /*GD.Print(">>> HIGHLIGHT ATTEMPT on: ", lastHighlightedCard.Name);
                GD.Print("    Path: ", lastHighlightedCard.GetPath());
                GD.Print("    InsideTree: ", lastHighlightedCard.IsInsideTree());
                GD.Print("    InstanceId: ", lastHighlightedCard.GetInstanceId());*/
                lastHighlightedCard.Highlight(false);
                lastHighlightedCard = null;
            }

        }
        else if (lastHighlightedCard != null)
        {
            /*GD.Print(">>> HIGHLIGHT ATTEMPT on: ", lastHighlightedCard.Name);
            GD.Print("    Path: ", lastHighlightedCard.GetPath());
            GD.Print("    InsideTree: ", lastHighlightedCard.IsInsideTree());
            GD.Print("    InstanceId: ", lastHighlightedCard.GetInstanceId());*/
            lastHighlightedCard.Highlight(false);
            lastHighlightedCard = null;
        }

    }

}
