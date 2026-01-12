export class User {
    constructor(
        private name: string,
        private age: number
    ) { }

    getName(): string {
        return this.name;
    }

    getAge(): number {
        return this.age;
    }
}

// ❌ Over-fragmented examples
export class UserNamePrinter {
    print(name: string): void {
        console.log(name);
    }
}

export class UserAgePrinter {
    print(age: number): void {
        console.log(age);
    }
}

// ✅ Cohesive responsibility
export class UserProfilePrinter {
    print(user: User): void {
        console.log(user.getName());
        console.log(user.getAge());
    }
}

// ❌ Method-as-class examples
export class EmailValidator {
    isValid(email: string): boolean {
        return email.includes("@");
    }
}

export class UserRepository {
    save(user: User): void {
        console.log("Saving user");
    }
}

export class WelcomeEmailSender {
    send(user: User): void {
        console.log("Sending email");
    }
}

// ✅ SRP-correct coordinator
export class UserRegistrationService {
    constructor(
        private readonly validator: EmailValidator,
        private readonly repository: UserRepository,
        private readonly emailSender: WelcomeEmailSender
    ) { }

    register(user: User, email: string): void {
        if (!this.validator.isValid(email)) {
            throw new Error("Invalid email");
        }

        this.repository.save(user);
        this.emailSender.send(user);
    }
}
