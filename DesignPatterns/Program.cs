// See https://aka.ms/new-console-template for more information
using DesignPatterns.Creational;

// Thread safe singleton Lazy
async Task<SingletonLazyInitialized> GetSingletonLazyInitializedAsync()
{
    return await Task.Run(() => SingletonLazyInitialized.Instance());
}

var tasks = new List<Task<SingletonLazyInitialized>>();
for (int i = 0; i < 1000; i++)
{
    tasks.Add(GetSingletonLazyInitializedAsync());

}
await Task.WhenAll(tasks);
// Task.WaitAll(tasks.ToArray());

foreach (var task in tasks)
{
    Console.WriteLine(task.Result.GetHashCode());
}


Console.ReadKey();