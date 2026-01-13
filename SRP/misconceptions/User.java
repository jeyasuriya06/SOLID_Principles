package SRP;

public class User {
    String name;
    int age;
    
    public String getName(){
        return name;
    }

    public int getAge() {
        return age;
    }
}

class UserNamePrinter {
    void print(String name) {
        System.out.println(name);
    }
}

class UserAgePrinter {
    void print(int age) {
        System.out.println(age);
    }
}

class UserProfilePrinter {
    void print(User user) {
        System.out.println(user.getName());
        System.out.println(user.getAge());
    }
}

class ValidateEmail {
    boolean execute(String email) {
        return email.contains("@");
    }
}

class SaveUser {
    void execute(User user) {
        System.out.println("Saving user");
    }
}

class SendWelcomeEmail {
    void execute(User user) {
        System.out.println("Sending email");
    }
}

class UserRegistrationService {

    void register(User user) {
        validate(user);
        save(user);
        sendWelcomeEmail(user);
    }

    private void validate(User user) { }
    private void save(User user) { }
    private void sendWelcomeEmail(User user) { }
}


