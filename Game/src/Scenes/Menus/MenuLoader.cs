/*
A class to load a Menu JSON using the Menudata objects
*/

using System.Text.Json;
using MenuData;

public static class MenuDataLoader
{
    /// <summary>
    /// Tries to deserialize a Json with information about a Menu.
    /// </summary>
    /// <param name="dataDirectory"></param>
    /// <returns>A Deserialized Json data if the Deserialization operation succeeded. Else, it returns null.</returns>
    /// <exception cref="FileNotFoundException"> Throws an error if the firectory specified does not exist</exception>
    public static JsonData? LoadMenuData(string dataDirectory)
    {
        if (!Directory.Exists(dataDirectory))
        {
            throw new FileNotFoundException($"Could not find the following file: {dataDirectory}");
        }
        string jsonString = File.ReadAllText(dataDirectory);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        JsonData? data = JsonSerializer.Deserialize<JsonData>(jsonString, options);

        return data;
    }
}
