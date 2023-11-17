namespace DIExample;

public class SingletonProvider:IProvider
{
    private static SampleService _sample;
    public SampleService GetSample()
    {
        if (_sample == null)
            _sample = new SampleService();
        return _sample;
    }
}