using Godot;

/**
 * A script for the initial scene of the game
 */
public class SaveFileSelectScene : Control {

	//A packed scene that prepares the test scene
	private PackedScene _testScene;

	public override void _Ready() {
		this._testScene = ResourceLoader.Load("res://Scenes/Areas/PlayerUnknownsTestingGrounds.tscn") as PackedScene;
		this.GetNode<Button>("TestButton").Connect("pressed", this, nameof(this.GoToTest));
	}

	private void GoToTest() {
		this.GetTree().ChangeSceneTo(this._testScene);
	}

}
