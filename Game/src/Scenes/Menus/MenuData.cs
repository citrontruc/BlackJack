/*
A class to define the elements in a menu.
Used to read and parse json elements.
*/

namespace BlackJack.Scenes.Menus;

public record JsonData
{
    public List<AssetData>? Assets { get; init; }
    public List<TextData>? Text { get; init; }
    public string NextScene { get; init; }
}

public record AssetData
{
    public required string Name { get; init; }
    public required ElementPosition Position { get; init; }
    public required ElementSize Size { get; init; }
    public int Angle { get; init; }
}

public record TextData
{
    public required string Value { get; init; }
    public required ElementPosition Position { get; init; }
    public required ElementSize Size { get; init; }
    public required string Color { get; init; }
    public int FontSize { get; init; }
    public OnClickAction? onClick { get; init; }
    public OnHoverAction? onHover { get; init; }
}

public record ElementPosition
{
    public int x { get; init; }
    public int y { get; init; }
}

public record ElementSize
{
    public int x { get; init; }
    public int y { get; init; }
}

public record OnClickAction
{
    public required string Name { get; init; }
    public required string Value { get; init; }
}

public record OnHoverAction
{
    public required string Name { get; init; }
    public required string Value { get; init; }
}
