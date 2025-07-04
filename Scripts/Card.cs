using Godot;
using System;

public partial class Card : Node3D, IClickable
{
    public CardData cardData { get; set; }
    private Vector3 baseScale;

    public bool IsDraggable;
    public bool IsBeingDragged = false;
    public enum CardState { Active, InHand, AtStation, InDeck, InDiscard, InExile };


    public override void _Ready()
    {
        AddToGroup("Player_Selectable_Cards");
        baseScale = GetNode<MeshInstance3D>("CardBody/CardMesh3D").Scale;
    }

    public override void _PhysicsProcess(double delta)
    {
        //Future me- This is going to be where a lot of the state engine lives. As I write this, it's just going to check for 
        //dragging and then move the card under the mouse.
        if (IsBeingDragged)
        {
            if (!Input.IsMouseButtonPressed(MouseButton.Left))
            {
                IsBeingDragged = false;
            }
            else
            {
                // Get mouse ray from camera
                Camera3D camera = GetViewport().GetCamera3D();
                Vector2 mousePos = GetViewport().GetMousePosition();
                Vector3 rayOrigin = camera.ProjectRayOrigin(mousePos);
                Vector3 rayDirection = camera.ProjectRayNormal(mousePos);

                // Define the Y height of the playmat or card hover height
                float fixedY = 0.05f;

                // Solve for t where the ray hits Y = fixedY
                float t = (fixedY - rayOrigin.Y) / rayDirection.Y;
                Vector3 intersection = rayOrigin + rayDirection * t;

                GlobalPosition = intersection;
            }
        }
    }



    public void Highlight(bool On)
    {
        /*GD.Print($"Highlight called on: {Name} [Tree: {IsInsideTree()}]");

        foreach (var child in GetChildren())
        {
            GD.Print($"  Child: {child.Name} ({child.GetType().Name})");
        }*/

        if (!(IsInsideTree()))
        {
            return;
        }
        var mesh = GetNode<MeshInstance3D>("CardBody/CardMesh3D");
        var highlightMesh = GetNode<MeshInstance3D>("CardBody/HighlightMesh3D");
        var highlightMat = highlightMesh.GetActiveMaterial(0) as StandardMaterial3D;

        if (On)
        {
            //GD.Print("Card is highlighted!");
            mesh.Scale = new Vector3(
                baseScale.X * 1.1f,
                baseScale.Y * 1.1f,
                baseScale.Z
            );

            if (highlightMat != null)
            {
                highlightMesh.Visible = true;
                highlightMat.Emission = new Color(1.5f, 1.2f, 0.25f);
                highlightMesh.MaterialOverride = highlightMat;
                highlightMat.EmissionEnabled = true;
                highlightMat.EmissionEnergyMultiplier = 3.0f;
            }
        }
        else
        {
            //GD.Print("Card isn't highlighted anymore...");
            mesh.Scale = baseScale;
            if (highlightMat != null)
            {
                highlightMat.EmissionEnabled = false;
                highlightMesh.Visible = false;
            }

        }
    }

    public void OnClicked(InputEventMouseButton mouse)
    {
        if (Input.IsMouseButtonPressed(MouseButton.Left))
        {
            if (IsDraggable)
            {
                IsBeingDragged = true;
            }
            else
            {
                GD.Print("Try all you want, I won't drag!");
            }
        }
        else
        {
            GD.Print("Twas an earnest click!");
        }
    }
}
