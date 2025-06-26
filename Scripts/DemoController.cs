using Godot;
using System;

public partial class DemoController : Node
{
        [Export]
    public PackedScene CardPreFab;
    [Export]
    public PackedScene TorpedoPreFab;
    [Export]
    public Node3D CardSpawnPoint;
    [Export]
    public Node3D TorpedoLaunchPoint;
    [Export]
    Node3D TorpedoImpactPoint;

    /* -------------------------------------------------------------*/

    public override void _Ready()
    {
        SpawnCard();
        FireTestTorpedo();
    }

    private void SpawnCard()
    {
        var card = CardPreFab.Instantiate<Node3D>();
        card.Position = CardSpawnPoint.GlobalPosition;
        AddChild(card);
    }

    private async void FireTestTorpedo()
    {
        var torpedo = TorpedoPreFab.Instantiate<Node3D>();
        torpedo.Position = TorpedoLaunchPoint.GlobalPosition;
        AddChild(torpedo);

        var tween = CreateTween();
        tween.TweenProperty(torpedo, "position", TorpedoImpactPoint.GlobalPosition, 1.5f)
            .SetTrans(Tween.TransitionType.Sine)
            .SetEase(Tween.EaseType.InOut); //The fuck does this do!?

        await ToSignal(tween, Tween.SignalName.Finished);

        var particles = new GpuParticles3D();
        particles.Amount = 50;
        particles.Lifetime = 1.0f;
        particles.OneShot = true;
        particles.Preprocess = 0.0f;

        var material = new ParticleProcessMaterial();
        material.Color = new Color(1.0f, 0.5f, 0.2f, 1.0f);
        material.Gravity = new Vector3(0, -1, 0);
        material.InitialVelocityMin = 3.0f;
        material.InitialVelocityMax = 6.0f;
        material.Spread = 180.0f;
        material.Direction = Vector3.Up;

        particles.Emitting = true;

    }
}
