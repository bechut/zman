using Godot;
using System;

namespace Yman
{
	public partial class Playground : Node2D
	{
		private const string CharacterScenePath = $"res://Scenes/Character/Character.tscn";
		private PackedScene characterScene;
		private Character character;

		public override void _Ready()
		{
			characterScene = GD.Load<PackedScene>(CharacterScenePath);
			character = (Character)characterScene.Instantiate();
			AddChild(character);
			character.GlobalPosition = new Vector2(100, 100);
		}
	}
}
