using Godot;
using System;


public partial class Menu : Control
{

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		FlappyBird.State = FlappyBird.GameState.MENU;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(Input.IsActionJustReleased("enter"))
		{
			GetTree().ChangeSceneToFile("res://Scenes/Game.tscn");
		}
	}
}
