using Godot;
using System;

public partial class IdLabel : Label, IUsesCardId, IUsesCardSize
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public void UpdateCardId(string id)
	{
		Text = id;
	}
	//doesn't resize, but realigns
	public void UpdateCardSize(Vector2 size)
	{
		var parentBottomLeft = new Vector2(-size.X, size.Y) / 2;
		var thisBottomLeft = new Vector2(0, Size.Y);
		Position = parentBottomLeft - thisBottomLeft;
	}
}
