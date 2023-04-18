namespace DependencyInjection;

class DiLifetimeTesterResult
{
    public int Singleton { get; set; }
    public int Scoped { get; set; }
    public int Transient { get; set; }
}