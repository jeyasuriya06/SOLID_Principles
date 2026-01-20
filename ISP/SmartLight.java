interface Switchable {
    void turnOn();
    void turnOff();
}
interface Playable {
    void play();
    void stop();
}

public class SmartLight implements Switchable {

    @Override
    public void turnOn() {
        System.out.println("On");
    }

    @Override
    public void turnOff() {
        System.out.println("Off");
    }

}

@SuppressWarnings("unused")
class MusicPlayer implements Switchable, Playable {

    @Override
    public void turnOn() {
        System.out.println("On");
    }

    @Override
    public void turnOff() {
        System.out.println("Off");
    }

    @Override
    public void play() {
        System.out.println("Playing music");
    }

    @Override
    public void stop() {
        System.out.println("Stoped playing music");
    }

}