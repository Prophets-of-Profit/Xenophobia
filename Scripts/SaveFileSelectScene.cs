using Godot;

/**
 * A script for the initial scene of the game
 */
public class SaveFileSelectScene : Control {

	//A packed scene that prepares the test scene
	private PackedScene testScene;

	public override void _Ready() {
		this.GetNode<Button>("TestButton").Connect("pressed", this, nameof(this.GoToTest));
		this.testScene = ResourceLoader.Load("res://Scenes/Areas/PlayerUnknownsTestingGrounds.tscn") as PackedScene;
	}

	private void GoToTest() {
		this.GetTree().ChangeSceneTo(this.testScene);
	}

}
