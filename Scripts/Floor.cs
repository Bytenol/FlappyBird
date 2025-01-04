using Godot;
using System;

public partial class Floor : Area2D
{
	private float posY;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		posY = Position.Y;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(FlappyBird.State != FlappyBird.GameState.PLAYING) 
			return;
			
		Position += new Vector2(-FlappyBird.speed * (float)delta, 0.0f);
		if(Position.X <= -FlappyBird.Width)
		{
			Position = new Vector2(FlappyBird.Width, posY);
		}
	}
}
