
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// Register Singleton
// Register Transient
// Register Scoped

// Let tester be created as transient


// Configure the HTTP request pipeline.





class DILifetimeTester : IDILifetimeTester
{
    private readonly IScoped scoped;
    private readonly ISingleton singleton;
    private readonly ITransient transient;

    public DILifetimeTester(ISingleton singleton, IScoped scoped, ITransient transient)
    {
        this.singleton = singleton;
        this.transient = transient;
        this.scoped = scoped;
    }

    public DILifetimeTesterResult GetHashCodes()
    {
        return new DILifetimeTesterResult
        {
            singleton = singleton.GetHashCode(),
            scoped = scoped.GetHashCode(),
            transient = transient.GetHashCode(),
        };
    }
}
