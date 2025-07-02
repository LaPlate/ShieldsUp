using Godot;
using System;
using System.Runtime.CompilerServices;

public partial class Main : Node3D
{

    [Export]
    CardFactory cardFactory;

    public Card demoCard;
    Camera3D camera = new();

    public override void _Ready()
    {

        camera = GetNode<Camera3D>("Room Elements/PlayerViewCamera");
        demoCard = cardFactory.DrawRandomCard(CardData.cardType.Player);
        GD.Print("demoCard is loaded as " + demoCard.cardData.CardTitle);
        AddChild(demoCard);
        demoCard.GlobalPosition = new Vector3(0.0f, 0.0f, 1.0f);
        demoCard.GetNode<RigidBody3D>("CardBody").Freeze = true;
        GD.Print(demoCard.GetNode<RigidBody3D>("CardBody").Name);
        GD.Print(demoCard.GetNode<MeshInstance3D>("CardBody/CardMesh3D").Name);
        camera.LookAt(demoCard.GlobalPosition);

    }

    public override void _PhysicsProcess(double delta)
    {
        if (demoCard != null && demoCard.IsInsideTree())
        {
            camera.LookAt(demoCard.GlobalPosition);
        }
        else
        {
            GD.Print(demoCard.cardData.CardTitle);
        }
    }


}
