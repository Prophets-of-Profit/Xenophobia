using Godot;

public class Player : Actor {

	public override void _PhysicsProcess(float delta) {
		this.velocityDirection = new Vector2(
			Input.GetActionStrength("move_right") - Input.GetActionStrength("move_left"),
			Input.GetActionStrength("move_down") - Input.GetActionStrength("move_up")
		);
		base._PhysicsProcess(delta);
	}

}
