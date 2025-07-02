using Godot;
using System;

public partial class Card : Node3D
{
    public CardData cardData { get; set; }
    private Vector3 baseScale;

    public override void _Ready()
    {
        AddToGroup("Player_Selectable_Cards");
        baseScale = GetNode<MeshInstance3D>("CardBody/CardMesh3D").Scale;
    }


    public void Highlight(bool On)
    {
        GD.Print($"Highlight called on: {Name} [Tree: {IsInsideTree()}]");

        foreach (var child in GetChildren())
        {
            GD.Print($"  Child: {child.Name} ({child.GetType().Name})");
        }

        if (!(IsInsideTree()))
        {
            return;
        }
        var mesh = GetNode<MeshInstance3D>("CardBody/CardMesh3D");
        var highlightMesh = GetNode<MeshInstance3D>("CardBody/HighlightMesh3D");
        var highlightMat = highlightMesh.GetActiveMaterial(0) as StandardMaterial3D;

        if (On)
        {
            GD.Print("Card is highlighted!");

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
            GD.Print("Card isn't highlighted anymore...");
            mesh.Scale = baseScale;
            if (highlightMat != null)
            {
                highlightMat.EmissionEnabled = false;
                highlightMesh.Visible = false;
            }

        }
    }
}
