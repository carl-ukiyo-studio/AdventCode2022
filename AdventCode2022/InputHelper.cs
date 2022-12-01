using System.Text;

namespace AdventCode2022;

public class InputHelper
{
    
    public static StreamReader ConvertStringToStream(string input) => new(new MemoryStream(Encoding.UTF8.GetBytes(input)));

    public static async Task<StreamReader> GetInput(int day)
    {
        var file = $"day{day}.txt";

        if (!File.Exists(file))
        {
            var input = await GetInputFromUrl(day);
            await using StreamWriter writer = new(file);
            await writer.WriteAsync(input);
        }

        return new StreamReader(file);
    }

    private static async Task<string> GetInputFromUrl(int day)
    {
        var sessionCookie = await File.ReadAllTextAsync("cookie.txt");

        var client = new HttpClient();
        HttpRequestMessage request = new(HttpMethod.Get, $"https://adventofcode.com/2022/day/{day}/input");
        request.Headers.TryAddWithoutValidation("Cookie", $"session={sessionCookie}");
        HttpResponseMessage response = await client.SendAsync(request);
        return await response.Content.ReadAsStringAsync();
    }
}