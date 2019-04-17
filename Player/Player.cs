using Godot;
using System;

/**
 * A class that represents the main player of the game
 * Is the entity that the user controls to play the game
 */
public class Player : KinematicBody2D
{

	//The maximum speed that the player is allowed to move
	private float maxSpeed = 750;
	//The player's current velocity as a vector: is set in _Input and used in _PhysicsProcess
	private Vector2 velocity = new Vector2(0, 0);

	/**
	 * Updates the sprite or appearance of the player based on its velocity
	 */
	private void UpdateSprite()
	{
		String newTexturePath = "res://Player/Xenu-";
		if (Math.Abs(this.velocity.x) > Math.Abs(this.velocity.y))
		{
			if (this.velocity.x > 0)
			{
				newTexturePath += "Right";
			}
			else
			{
				newTexturePath += "Left";
			}
		}
		else if (Math.Abs(this.velocity.x) < Math.Abs(this.velocity.y))
		{
			if (this.velocity.y > 0)
			{
				newTexturePath += "Down";
			}
			else
			{
				newTexturePath += "Up";
			}
		}
		else
		{
			return;
		}
		newTexturePath += ".png";
		(this.FindNode("PlayerSprite") as Sprite).SetTexture(ResourceLoader.Load(newTexturePath) as Texture);
	}

	/**
	 * On ready, the player shrinks its size slightly so that it can fit between blocks/tiles more easily
	 */
	public override void _Ready()
	{
		RectangleShape2D playerCollider = (this.FindNode("PlayerCollider") as CollisionShape2D).GetShape() as RectangleShape2D;
		playerCollider.SetExtents(playerCollider.GetExtents() - new Vector2(2, 2));
	}

	/**
	 * Moves the player by the amount specified by its velocity
	 */
	public override void _PhysicsProcess(float delta)
	{
		this.MoveAndSlide(this.velocity);
	}

	/**
	 * Reads inputs and sets the player's velocity accordingly
	 */
	public override void _Input(InputEvent e)
	{
		this.velocity.x = Input.GetActionStrength("move_right") - Input.GetActionStrength("move_left");
		this.velocity.y = Input.GetActionStrength("move_down") - Input.GetActionStrength("move_up");
		this.velocity *= this.maxSpeed;
		if (this.velocity.LengthSquared() >= Math.Pow(this.maxSpeed, 2))
		{
			this.velocity = this.velocity.Normalized() * this.maxSpeed;
		}
		this.UpdateSprite();
	}

}
