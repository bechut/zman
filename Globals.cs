using Godot;


public partial class Globals : Node
{
	public enum Direction
	{
		Up,
		Down,
		Left,
		Right
	}

	// Store last direction globally
	public static string ToShortString(Direction dir)
	{
		return dir switch
		{
			Direction.Up => "u",
			Direction.Down => "d",
			Direction.Left => "l",
			Direction.Right => "r",
			_ => ""
		};
	}
}
