/*
A class to define the elements in a menu.
Used to read and parse json elements.
*/

namespace MenuData;

public record class JsonData
{
    public List<AssetData>? Assets { get; init; }
    public List<TextData>? Text { get; init; }
}

public record class AssetData
{
    public required string Name { get; init; }
    public required ElementPosition Position { get; init; }
    public required ElementSize Size { get; init; }
    public int Angle { get; init; }
}

public record class TextData
{
    public required string Value { get; init; }
    public required ElementPosition Position { get; init; }
    public required ElementSize Size { get; init; }
    public required string Color { get; init; }
    public int FontSize { get; init; }
    public OnClickAction? onClick { get; init; }
}

public record class ElementPosition
{
    public int x { get; init; }
    public int y { get; init; }
}

public record class ElementSize
{
    public int x { get; init; }
    public int y { get; init; }
}

public record OnClickAction
{
    public required string Name { get; init; }
    public required string Value { get; init; }
}
