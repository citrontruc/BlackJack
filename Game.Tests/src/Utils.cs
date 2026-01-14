using Xunit;

public class RaylibFactAttribute : FactAttribute
{
    public RaylibFactAttribute()
    {
        if (Environment.GetEnvironmentVariable("CI") == "true")
        {
            Skip = "Raylib tests are disabled in CI";
        }
    }
}
