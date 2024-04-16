using Godot;
using System;

public partial class CardShape : CollisionShape2D, IUsesCardSize
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void UpdateCardSize(Vector2 size)
	{
        Shape = new RectangleShape2D
        {
            Size = size
        };
	}
}
