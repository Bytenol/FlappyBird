using Godot;


public class FlappyBird
{
	private static float _speed;
	private static readonly int _width;
	private static readonly int _height;
	
	public enum GameState
	{
		MENU,
		PAUSED,
		PLAYING,
		OVER
	};
	
	public static GameState State;

	public static float speed
	{
		get { return _speed; }
		set { _speed = value; }
	}
	
	public static int Width
	{
		get { return _width; }
	}
	
	public static int Height
	{
		get { return _height; }
	}

	public static bool IsDay;

	public static void setBackground()
	{
	}

	static FlappyBird()
	{
		State = GameState.MENU;
		IsDay = true;
		speed = 40.0f;
		_width = 364;
		_height = 650;
	}

}
