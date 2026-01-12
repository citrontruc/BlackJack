/*
A class to load a Menu JSON using the Menudata objects
*/

using System.Text.Json;
using MenuData;

public class MenuDataLoader
{
    public JsonData? LoadMenuData(string dataDirectory)
    {
        string jsonString = File.ReadAllText(dataDirectory);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        JsonData? data = JsonSerializer.Deserialize<JsonData>(jsonString, options);

        return data;
    }
}
