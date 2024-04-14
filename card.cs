using Godot;
using System;

public partial class card : Area2D
{
	private Vector2 MouseOffset { get; set; }
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		InputPickable = true;
		//TODO worry about dragging later, websocket control is more important
		//InputEvent += MouseClick;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void MouseClick(Node viewport, InputEvent @event, long shapeIdx)
	{
		if (@event is InputEventMouse mouseEvent)
		{
			if (mouseEvent.IsActionPressed("click"))
			{

			}
			else if (mouseEvent.IsActionReleased("click"))
			{

			}
		}
	}
}
