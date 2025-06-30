using Godot;
using System;
using System.Runtime.CompilerServices;

public partial class Main : Node3D
{

    [Export]
    CardFactory cardFactory;

    public Card demoCard = new();
    Camera3D camera = new();

    public override void _Ready()
    {

        camera = GetNode<Camera3D>("Room Elements/PlayerViewCamera");
        demoCard = cardFactory.DrawRandomCard(CardData.cardType.Player);
        AddChild(demoCard);
        demoCard.GlobalPosition = new Vector3(0.0f, 0.0f, 1.0f);
        demoCard.GetNode<RigidBody3D>("RigidBody3D").Freeze = true;
        camera.LookAt(demoCard.GlobalPosition);

    }

    public override void _PhysicsProcess(double delta)
    {
        camera.LookAt(demoCard.GlobalPosition);
    }


}
