// See https://aka.ms/new-console-template for more information
using DesignPatterns.Creational;

#region Thread safe singleton - Lazy initialized
// Thread safe singleton Lazy
async Task<SingletonLazyInitialized> GetSingletonLazyInitializedAsync()
{
    return await Task.Run(() => SingletonLazyInitialized.Instance());
}

var tasks = new List<Task<SingletonLazyInitialized>>();
for (var i = 0; i < 1000; i++)
{
    tasks.Add(GetSingletonLazyInitializedAsync());
}
Console.WriteLine($"Tasks fired:{DateTime.UtcNow:O}");
await Task.WhenAll(tasks);
// Task.WaitAll(tasks.ToArray());
Console.WriteLine($"Tasks completed:{DateTime.UtcNow:O}");
var distinctObjects = tasks.Select(task => task.Result.GetHashCode()).Distinct().ToList();

Console.WriteLine($"There are {distinctObjects.Count()} distinct objects. First one is {distinctObjects.First()}"); 
#endregion


Console.ReadKey();