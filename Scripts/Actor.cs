using Godot;

public class Actor : KinematicBody2D {

	public float speed = 800;
	public Vector2 velocityDirection = Vector2.Zero;

	public override void _PhysicsProcess(float delta) {
		this.MoveAndSlide(this.velocityDirection.Normalized() * this.speed);
	}

}
