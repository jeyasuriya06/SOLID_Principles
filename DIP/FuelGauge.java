interface FuelGauge {
    int level();
}

class RemoteFuelGauge implements FuelGauge{

    public int level() {
        return 80;
    }
}

class TestingFuelGauge implements FuelGauge {
    public int level() {
        return 100;
    }
}

