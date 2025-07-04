using Godot;
using System;

public partial class MouseClickManager : Node3D
{

    [Export]
    Camera3D camera;
    public override void _Input(InputEvent @event)
    {
        {
            if (@event is InputEventMouseButton mouse && mouse.Pressed && mouse.ButtonIndex == MouseButton.Left)
            {
                HandleMouseClick(mouse);
            }

        }

    }

    public void HandleMouseClick(InputEventMouseButton mouse)
    {
        var mousePos = GetViewport().GetMousePosition();
        var rayOrigin = camera.ProjectRayOrigin(mousePos);
        var rayDir = camera.ProjectRayNormal(mousePos);
        var spaceState = GetWorld3D().DirectSpaceState;

        var query = PhysicsRayQueryParameters3D.Create(rayOrigin, rayOrigin + rayDir * 1000);
        var result = spaceState.IntersectRay(query);


        if (result.TryGetValue("collider", out var colliderVariant))
        {
            var node = colliderVariant.As<Node>();
            var clickableNode = FindParentClickable(node);

            // Generic handler interface
            if (mouse is InputEventMouseButton mouseButton && mouseButton.Pressed && clickableNode is IClickable clickable)
            {
                clickable.OnClicked(mouseButton);
            }
            else
            {
                node.EmitSignal("Clicked"); // if using custom signals
            }
        }
    }

    public Node FindParentClickable(Node node)
    {
        while (node != null)
        {
            if (node is IClickable clickable)
                return clickable as Node;
            node = node.GetParent();
        }
        return null;
    }
}
