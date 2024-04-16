using System.Collections.Generic;
using Godot;

public static class ExtensionHelper
{
    public static Card GetCardWithId(this SceneTree tree, string id)
    {
        const string CardGroup = "Card";
        var cards = tree.GetNodesInGroup(CardGroup);
        foreach (var card in cards)
        {
            if (card is Card c)
            {
                if (c.Id == id)
                    return c;
            }
            else
                throw new System.Exception($"Node in group {CardGroup} is not of type {nameof(Card)}");
        }
        return null;
    }
    public static Row GetRowWithId(this SceneTree tree, string id)
    {
        const string RowGroup = "Card";
        var rows = tree.GetNodesInGroup(RowGroup);
        foreach (var row in rows)
        {
            if (row is Row r)
            {
                if (r.Id == id)
                    return r;
            }
            else
                throw new System.Exception($"Node in group {RowGroup} is not of type {nameof(Row)}");
        }
        return null;
    }
    public static IEnumerable<Node> GetAllDescendents(this Node node, bool includeInternal = false)
    {
        foreach (Node n in node.GetChildren(includeInternal))
        {
            yield return n;
            foreach (Node c in n.GetAllDescendents())
                yield return c;
        }
    }
    // gets all descendents of a given type (in undefined order)
    public static IEnumerable<T> GetAllDescendents<T>(this Node node,
        bool includeInternal = false)
    {
        foreach (var n in node.GetAllDescendents(includeInternal))
            if (n is T t)
                yield return t;
    }
}
