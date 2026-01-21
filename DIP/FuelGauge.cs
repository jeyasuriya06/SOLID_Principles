// Abstraction
public interface IFuelGauge
{
    int Level();
}

// Real implementation
public class RemoteFuelGauge : IFuelGauge
{
    public int Level()
    {
        return 80; // Real hardware value
    }
}

// Test implementation
public class TestingFuelGauge : IFuelGauge
{
    public int Level()
    {
        return 100; // test value
    }
}

class RocketLauncher
{
    private IFuelGauge _fuelGauge;

    public RocketLauncher(IFuelGauge fuelGauge)
    {
        _fuelGauge = fuelGauge;
    }

    public bool IsSafeToLaunch()
    {
        return _fuelGauge.Level() > 50;
    }
}

// Test
class Program
{
    static void Main()
    {
        IFuelGauge testGauge = new TestingFuelGauge();
        RocketLauncher rocket = new RocketLauncher(testGauge);

        Console.WriteLine(rocket.IsSafeToLaunch());
    }
}
