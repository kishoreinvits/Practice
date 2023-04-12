var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register Singleton
builder.Services.AddSingleton<ISingleton, Singleton>();
// Register Transient
builder.Services.AddTransient<ITransient, Transient>();
// Register Scoped
builder.Services.AddScoped<IScoped, Scoped>();

// Let tester be created as transient
builder.Services.AddTransient<IDILifetimeTester, DILifetimeTester>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/test", (ISingleton singleton, IScoped scoped, ITransient transient, IDILifetimeTester tester) =>
{
    var hashCodesFromTester = tester.GetHashCodes();
    return new
    {
        singletonDescription = "These shall be same betwen requests too",
        singletonFirst = singleton.GetHashCode(),
        singletonSecond = hashCodesFromTester.singleton,
        scopedDescription = "These shall be same within a request",
        scopedFirst = scoped.GetHashCode(),
        scopedSecond = hashCodesFromTester.scoped,
        transientDescription = "These shall be different everytime even within a request",
        transientFirst = transient.GetHashCode(),
        transientSecond = hashCodesFromTester.transient,
    };
});

app.Run();
