
namespace DependencyInjection;

class DiLifetimeTester : IDiLifetimeTester
{
    private readonly IScoped _scoped;
    private readonly ISingleton _singleton;
    private readonly ITransient _transient;

    public DiLifetimeTester(ISingleton singleton, IScoped scoped, ITransient transient)
    {
        this._singleton = singleton;
        this._transient = transient;
        this._scoped = scoped;
    }

    public DiLifetimeTesterResult GetHashCodes()
    {
        return new DiLifetimeTesterResult
        {
            Singleton = _singleton.GetHashCode(),
            Scoped = _scoped.GetHashCode(),
            Transient = _transient.GetHashCode(),
        };
    }
}