using Godot;

public class Actor : KinematicBody2D {

	public float Speed = 800f;
	public Vector2 VelocityDirection = Vector2.Zero;

	public override void _PhysicsProcess(float delta) {
		this.MoveAndSlide(this.VelocityDirection.Normalized() * this.Speed);
	}

}
