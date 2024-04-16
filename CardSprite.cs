using Godot;
using System;

public partial class CardSprite : Sprite2D, IUsesCardSize
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//set scale for default color
		// if (GetParent<CardCollisionShape2D>()?.Shape is RectangleShape2D rect)
		//     Scale = rect.Size;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void UpdateCardSize(Vector2 size)
	{
		var s = Texture.GetSize();
		Scale = new Vector2(size.X / s.X, size.Y / s.Y);
	}
}
