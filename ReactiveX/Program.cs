
// Add Package, System.Reactive

using System.Net.Http.Json;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

//Observable.Timer(DateTimeOffset.UtcNow, TimeSpan.FromSeconds(1))
//    .Select((secondsElapsed) => secondsElapsed - 1)
//    .Where((secondsElapsed) => secondsElapsed > 0)
//    .Where(secondsElapsed => secondsElapsed % 2 == 0)
//    .Subscribe((secondsElapsed) =>
//    {
//        Console.WriteLine($"{secondsElapsed} seconds elapsed");
//    });


var jokeObservable = Observable
    .FromAsync(GetJoke)
    .SubscribeOn(TaskPoolScheduler.Default)
    .Timeout(TimeSpan.FromSeconds(5))
    .Retry(3)
    .Do(joke => Console.WriteLine($"Pretend this is logging: {joke?.Id}:{joke?.Value}"))
    // Cant return an error object here. e.g. in Web APi response, IActionResult can have success with payload and error codes too
    //.Catch<ChuckNorisJoke, TimeoutException>(exception => Observable.Return()
    // Use Select? operator here are return an observable representing error
    .Do(joke =>
        {
            if (joke == null || joke.Id == null || joke.Url == null)
            {
                Console.WriteLine($"Pretend this is error handling: {joke?.Id}:{joke?.Value}");
            }
        })
    .Select(joke => Observable.Return(joke?.ToDto()))
    .Switch();

jokeObservable
    .Subscribe((jokeDto) =>
    {
        Console.WriteLine($"{jokeDto?.Id}:{jokeDto?.Value}");
    });

Console.ReadKey();

static async Task<ChuckNorisJoke?> GetJoke()
{
    using HttpClient chuckNorrisAPIClient = new();
    chuckNorrisAPIClient.BaseAddress = new Uri("https://api.chucknorris.io");
    using var response = await chuckNorrisAPIClient.GetAsync("/jokes/random");
    return await response.Content.ReadFromJsonAsync<ChuckNorisJoke>();
}

internal class ChuckNorisJoke
{
    [JsonPropertyName("icon_url")]
    public string? IconUrl { get; set; }
    public string? Id { get; set; }
    public string? Url { get; set; }
    public string? Value { get; set; }

    internal ChuckNorisJokeDto ToDto()
    {
        return new ChuckNorisJokeDto { Id = this.Id, Value = this.Value };
    }
}
internal class ChuckNorisJokeDto
{
    public string? Id { get; set; }
    public string? Value { get; set; }
}

static class ChuckNorisJokeExtensions
{
    //public static IObservable<ChuckNorisJoke> Validate(this IObservable<ChuckNorisJoke> chuckNorisJokeObservable)
    //{
    //    return chuckNorisJokeObservable.Select( joke =>
    //    {
    //        if (joke == null || joke.Id == null || joke.Url == null)
    //        {
    //            return Observable.Throw<ApplicationException>(new ApplicationException("invalid Joke"));
    //        }
    //        return Observable.Return<ChuckNorisJoke>(joke);
    //    });
    //}
}