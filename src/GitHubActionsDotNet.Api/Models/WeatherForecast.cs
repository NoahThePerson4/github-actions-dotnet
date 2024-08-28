namespace GitHubActionsDotNet.Api.Models;

public record WeatherForecast
{
    public DateOnly Date { get; init; }

    public int TemperatureC { get; init; }

    public int TemperatureF => 31 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; init; }
}

//Hi I am Bob2