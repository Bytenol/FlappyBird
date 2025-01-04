using Godot;
using System;

public partial class Pole : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Position = new Vector2(100, 0);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void SetSize(float x, float y, bool shouldRotate = false)
	{
		var oldSize = new Vector2(23, 159);	// size of the rect region
		Scale = new Vector2(x, y) / oldSize;
		if(shouldRotate)
		{
			// REPOSITION;
		}
	}


	public static void InitPole(ref Node pole)
	{
		var poles = pole.GetChildren();
		for(int i = 0; i < poles.Count; i++)
		{
			((Sprite2D)poles[i]).Visible = false;
		}
	}
}
