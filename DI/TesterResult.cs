
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// Register Singleton
// Register Transient
// Register Scoped

// Let tester be created as transient


// Configure the HTTP request pipeline.





class DILifetimeTesterResult
{
    public int singleton { get; set; }
    public int scoped { get; set; }
    public int transient { get; set; }
}