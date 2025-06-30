using Godot;
using System;
using System.Runtime.CompilerServices;

public partial class Main : Node3D
{

    [Export]
    CardFactory cardFactory;

    public Card demoCard = new();

    public override void _Ready()
    {
        Camera3D camera = GetNode<Camera3D>("Room Elements/PlayerViewCamera");
        CardData cData = new CardData
        {
            CardType = CardData.cardType.Player,
            CardTitle = "Demo the Hero",
            CardNum = 1
        };

        demoCard = cardFactory.CreateCard(cData);
        AddChild(demoCard);
        demoCard.GlobalPosition = new Vector3(0.0f, 0.0f, 1.0f);
        demoCard.GetNode<RigidBody3D>("RigidBody3D").Freeze = true;
        camera.LookAt(demoCard.GlobalPosition);

    }

    public override void _PhysicsProcess(double delta)
    {
        Camera3D camera = GetNode<Camera3D>("Room Elements/PlayerViewCamera");
        camera.LookAt(demoCard.GlobalPosition);
    }


}
