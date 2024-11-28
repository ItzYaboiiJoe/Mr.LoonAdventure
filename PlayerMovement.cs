using Godot;
using System;

public partial class PlayerMovement : CharacterBody2D
{
	[Export]
	public float Speed = 200.0f; // Character movement speed

	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		Vector2 velocity = Vector2.Zero;

		// Input handling
		if (Input.IsActionPressed("ui_right"))
		{
			velocity.X += 1;  // Correct casing for 'X'
		}
		if (Input.IsActionPressed("ui_left"))
		{
			velocity.X -= 1;  // Correct casing for 'X'
		}
		if (Input.IsActionPressed("ui_down"))
		{
			velocity.Y += 1;  // Correct casing for 'Y'
		}
		if (Input.IsActionPressed("ui_up"))
		{
			velocity.Y -= 1;  // Correct casing for 'Y'
		}

		// Normalize velocity to prevent faster diagonal movement
		if (velocity != Vector2.Zero)
		{
			velocity = velocity.Normalized() * Speed;
		}

		// Move the character
		Velocity = velocity;
		MoveAndSlide();
	}
}
