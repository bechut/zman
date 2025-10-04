using Godot;
using System;
using System.IO;

namespace Yman
{
	public partial class Anim : AnimatedSprite2D
	{
		private Character Parent;
		private StringName Type { get; set; } = $"idle";

		public override void _Ready()
		{
			Parent = (Character)GetParent();
			Play($"{Type}{Globals.ToShortString(Parent.LastDir)}");
		}

		public override void _Process(double delta)
		{
			if (Parent.IsRun)
			{
				Type = $"run";
			}
			else
			{
				Type = $"idle";
			}

			Play($"{Type}{Globals.ToShortString(Parent.LastDir)}");
		}
	}
}
