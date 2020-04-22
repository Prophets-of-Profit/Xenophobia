using Godot;

public class Player : Actor {

	public override void _Input(InputEvent @event) {
		this.VelocityDirection = new Vector2(
			Input.GetActionStrength("move_right") - Input.GetActionStrength("move_left"),
			Input.GetActionStrength("move_down") - Input.GetActionStrength("move_up")
		);
	}

	public override void _Process(float delta) {
		//TODO: handle animating player
	}

}
