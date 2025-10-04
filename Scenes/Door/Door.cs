using Godot;
using System;

namespace Yman
{
	public partial class Door : StaticBody2D
	{
		private AnimatedSprite2D Anim;
		private CollisionShape2D Shape;
		private bool IsOpen { get; set; } = false;
		private bool IsNearDoor { get; set; } = false;
		public override void _Ready()
		{
			Anim = GetNode<AnimatedSprite2D>("Anim");
			Shape = GetNode<CollisionShape2D>("Shape");

			Anim.AnimationFinished += () =>
			{
				Shape.Disabled = IsOpen;
			};
		}

		public override void _Process(double delta)
		{
			if (IsNearDoor && Input.IsActionJustPressed("action"))
			{
				if (IsOpen)
				{
					Anim.Play("close");
					IsOpen = false;
				}
				else
				{
					Anim.Play("open");
					IsOpen = true;
				}
			}
		}

		void OnBodyEntered(Node2D body)
		{
			if (body is Character character)
			{
				IsNearDoor = true;
				character.OpenButton();
			}
		}

		void OnBodyLeave(Node2D body)
		{
			if (body is Character character)
			{
				IsNearDoor = false;
				character.CloseButton();
			}
		}
	}
}
