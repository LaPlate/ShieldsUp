using Godot;
using System;


public partial class CameraRig : Node3D
{

    [Export]
    Camera3D camera;
    [Export]
    public float CameraScrollSpeed { get; set; }
    [Export]
    public float ZoomCloseLimit { get; set; }
    [Export]
    public float ZoomFarLimit { get; set; }
    private const float ACCELERATION = 20.0f;
    private const float FRICTION = 10.0f;

    private const float ZOOMSPEED = 0.1f;
    private Vector3 velocity = Vector3.Zero;
    private Vector3 zoomDirection;
    private bool isZooming = false;
    private float zoomTargetY;
    private float midZoomPoint;

    public override void _Ready()
    {

        midZoomPoint = camera.GlobalPosition.Y;
    }

    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventMouseButton mouseButton)
        {
        if (mouseButton.ButtonIndex == MouseButton.WheelUp)
            QueueZoom("In");
        else if (mouseButton.ButtonIndex == MouseButton.WheelDown)
            QueueZoom("Out");
        }
    }

    public override void _PhysicsProcess(double delta)
    {
        Vector3 directionInput = Vector3.Zero;

        if (Input.IsActionPressed("Camera_Scroll_Left"))
        {
            directionInput.X -= 1;
        }
        if (Input.IsActionPressed("Camera_Scroll_Right"))
        {
            directionInput.X += 1;
        }
        if (Input.IsActionPressed("Camera_Scroll_Up"))
        {
            directionInput.Z -= 1;
        }
        if (Input.IsActionPressed("Camera_Scroll_Down"))
        {
            directionInput.Z += 1;
        }

        if (directionInput != Vector3.Zero)
        {
            directionInput = directionInput.Normalized();
            velocity = velocity.MoveToward(directionInput * CameraScrollSpeed, ACCELERATION * (float)delta);
        }
        else
        {
            velocity = velocity.MoveToward(Vector3.Zero, FRICTION * (float)delta);
        }

        Translate(velocity * (float)delta);

    }
    public void QueueZoom(string dir)
    {
        Vector3 zoomDir = -camera.GlobalTransform.Basis.Z;

        if (dir == "Out")
            zoomDir = -zoomDir;

        float currentY = GlobalPosition.Y;
        float nextTarget = dir == "In" ? ZoomCloseLimit : ZoomFarLimit;

        // Compute a small step based on direction
        float zoomStepDistance = ZOOMSPEED; // or whatever you want per wheel tick
        float deltaY = zoomDir.Y * zoomStepDistance;

        // Prevent overshooting
        if ((dir == "In" && currentY + deltaY < ZoomCloseLimit) ||
            (dir == "Out" && currentY + deltaY > ZoomFarLimit))
        {
            return;
        }

        GlobalPosition += zoomDir * zoomStepDistance;
    }
}
