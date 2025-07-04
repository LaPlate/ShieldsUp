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

        camera = GetNode<Camera3D>("Room Elements/CameraRig/PlayerViewCamera");
        demoCard = cardFactory.DrawRandomCard(CardData.cardType.Player);
        GD.Print("demoCard is loaded as " + demoCard.cardData.CardTitle);
        AddChild(demoCard);
        demoCard.GlobalPosition = new Vector3(0.5f, 0.5f, 0.5f);
        var demoCardfreeze = demoCard.GetNode<RigidBody3D>("CardBody");
        demoCardfreeze.Freeze = true;
        demoCard.IsDraggable = true;

    }

    public override void _PhysicsProcess(double delta)
    {

    }
}
