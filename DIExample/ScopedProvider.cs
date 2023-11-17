namespace DIExample;

public class ScopedProvider:IProvider
{
    private SampleService _sampleService = null;
    public SampleService GetSample()
    {
        if (_sampleService == null)
        {
            _sampleService = new SampleService();
        }

        return _sampleService;
    }
}