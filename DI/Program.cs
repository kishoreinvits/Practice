using Microsoft.Extensions.DependencyInjection;

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
builder.Services.AddTransient<IDiLifetimeTester, DiLifetimeTester>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/test",
    (ISingleton singleton,
        IScoped scoped,
        ITransient transient,
        IDILifetimeTester tester,
        HttpContext context,
        ServiceProvider serviceProvider) =>
            {
                var hashCodesFromTester = tester.GetHashCodes();
                return new
                {
                    singletonDescription = "These shall be same between requests too",
                    singletonInjected = singleton.GetHashCode(),
                    singletonFromTester = hashCodesFromTester.singleton,
                    scopedDescription = "These shall be same within a request",
                    scopedInjected = scoped.GetHashCode(),
                    scopedFromTester = hashCodesFromTester.scoped,
                    transientDescription = "These shall be different everytime even within a request",
                    transientInjected = transient.GetHashCode(),
                    transientFromTester = hashCodesFromTester.transient,
                    transientFromServicesHttpContextServiceProvider = context.RequestServices.GetService<ITransient>(),
                    transientFromServicesServiceProvider = serviceProvider.GetService<ITransient>()
                    // These can be resolved from [FromServices] in method signature or ServiceProvider(not recommended) other than constructor injection
                };
            });

app.Run();
