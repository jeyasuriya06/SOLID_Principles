package SRP;

public class User {
    private final String email;

    public User(String email) {
        this.email = email;
    }

    public String getEmail() {
        return email;
    }
}

class EmailValidator {
    boolean isValid(String email) {
        return email.contains("@");
    }
}

class UserRepository {
    void save(User user) {
        System.out.println("Saving user");
    }
}

class WelcomeEmailSender {
    void send(User user) {
        System.out.println("Sending welcome email");
    }
}

class UserRegistrationService {

    private final EmailValidator validator;
    private final UserRepository repository;
    private final WelcomeEmailSender emailSender;

    UserRegistrationService(
        EmailValidator validator,
        UserRepository repository,
        WelcomeEmailSender emailSender
    ) {
        this.validator = validator;
        this.repository = repository;
        this.emailSender = emailSender;
    }

    void register(User user) {
        if (!validator.isValid(user.getEmail())) {
            throw new IllegalArgumentException("Invalid email");
        }

        repository.save(user);
        emailSender.send(user);
    }
}

