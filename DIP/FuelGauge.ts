// Abstraction
interface FuelGauge {
    level(): number;
}

// Real implementation
class RemoteFuelGauge implements FuelGauge {
    level(): number {
        return 80; // Real hardware value
    }
}

// Test implementation
class TestingFuelGauge implements FuelGauge {
    level(): number {
        return 100; // Test value
    }
}

// Higher level module
class RocketLauncher {
    private fuelGauge: FuelGauge;

    constructor(fuelGauge: FuelGauge) {
        this.fuelGauge = fuelGauge;
    }

    isSafeToLaunch(): boolean {
        return this.fuelGauge.level() > 50;
    }
}

// Test
const testGauge = new TestingFuelGauge();
const rocket = new RocketLauncher(testGauge);

console.log(rocket.isSafeToLaunch());
