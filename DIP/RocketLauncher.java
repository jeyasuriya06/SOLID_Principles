class RocketLauncher {
    private final FuelGauge fuelGauge;

    RocketLauncher(FuelGauge fuelGauge) {
        this.fuelGauge = fuelGauge;
    }

    boolean isSafeToLaunch() {
        return fuelGauge.level() > 50;
    }
}
