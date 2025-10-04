using Godot;
using System;

namespace Yman
{
	public partial class Character : CharacterBody2D
	{
		public float Speed { get; set; } = 200f;
		public Globals.Direction LastDir { get; set; } = Globals.Direction.Down;
		public bool IsRun { get; set; } = false;
		


		public override void _Ready()
		{
			GD.Print("Character ready");
		}

		public override void _PhysicsProcess(double delta)
		{
			GD.Print(Velocity.Angle());
			var velocity = new Vector2(0, 0);

			if (Input.IsActionPressed("Right"))
			{
				velocity.X += 1;
			}
			if (Input.IsActionPressed("Left"))
			{
				velocity.X -= 1;
			}
			if (Input.IsActionPressed("Down"))
			{
				velocity.Y += 1;
			}
			if (Input.IsActionPressed("Up"))
			{
				velocity.Y -= 1;
			}

			velocity = velocity.Normalized() * Speed;

			if (velocity != Vector2.Zero)
			{
				IsRun = true;
				if (Mathf.Abs(velocity.X) > Mathf.Abs(velocity.Y))
				{
					LastDir = velocity.X > 0 ? Globals.Direction.Right : Globals.Direction.Left;
				}
				else
				{
					LastDir = velocity.Y > 0 ? Globals.Direction.Down : Globals.Direction.Up;
				}
			}
			else
			{
				IsRun = false;
			}

			Velocity = velocity;
			MoveAndSlide();
		}
	}
}
