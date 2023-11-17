namespace DIExample;

public class Scope
{
    public IProvider TransientProvider { get; } = new TransientProvider();
    public IProvider SingletonProvider { get; } = new SingletonProvider();
    public IProvider ScopedProvider { get; } = new TransientProvider();
}