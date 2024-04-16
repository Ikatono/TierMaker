using Godot;
using System;
using System.Drawing;

public partial class Card : Area2D
{
	private Vector2 MouseOffset { get; set; }
	public Vector2 _Size;
	[Export]
	public Vector2 Size
	{
		get => _Size;
		set
		{
			_Size = value;
			UpdateChildrenSize(value);
		}
	}
	public CollisionShape2D CollisionObject
		=> GetNode<CollisionShape2D>("CollisionShape2D");
	public string _Id;
	[Export]
	public string Id
	{
		get => _Id;
	  	set
	  	{
			_Id = value;
			UpdateChildrenId(value);
	  	}
	}
	protected void UpdateChildrenId(string id)
	{
		foreach (var child in this.GetAllDescendents<IUsesCardId>())
			child.UpdateCardId(id);
	}
	protected void UpdateChildrenSize(Vector2 size)
	{
		foreach (var child in this.GetAllDescendents<IUsesCardSize>())
			child.UpdateCardSize(size);
	}
	//private Theme CardTheme = GD.Load<Theme>("res://card_theme.tres");
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		InputPickable = true;
		//TODO worry about dragging later, websocket control is more important
		//InputEvent += MouseClick;
		UpdateChildrenId(_Id);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	private static void MouseClick(Node viewport, InputEvent @event, long shapeIdx)
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

public interface IUsesCardId
{
	public void UpdateCardId(string id);
}

public interface IUsesCardSize
{
	public void UpdateCardSize(Vector2 size);
}