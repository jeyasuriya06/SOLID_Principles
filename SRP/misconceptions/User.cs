namespace SRP
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string GetName() => Name;
        public int GetAge() => Age;
    }

    // ❌ Over-fragmented examples
    class UserNamePrinter
    {
        public void Print(string name)
        {
            Console.WriteLine(name);
        }
    }

    class UserAgePrinter
    {
        public void Print(int age)
        {
            Console.WriteLine(age);
        }
    }

    // ✅ Cohesive responsibility
    class UserProfilePrinter
    {
        public void Print(User user)
        {
            Console.WriteLine(user.GetName());
            Console.WriteLine(user.GetAge());
        }
    }

    // ❌ Method-as-class examples
    class EmailValidator
    {
        public bool IsValid(string email)
        {
            return email.Contains("@");
        }
    }

    class UserRepository
    {
        public void Save(User user)
        {
            Console.WriteLine("Saving user");
        }
    }

    class WelcomeEmailSender
    {
        public void Send(User user)
        {
            Console.WriteLine("Sending email");
        }
    }

    // ✅ SRP-correct coordinator
    class UserRegistrationService
    {
        private readonly EmailValidator _validator;
        private readonly UserRepository _repository;
        private readonly WelcomeEmailSender _emailSender;

        public UserRegistrationService(
            EmailValidator validator,
            UserRepository repository,
            WelcomeEmailSender emailSender)
        {
            _validator = validator;
            _repository = repository;
            _emailSender = emailSender;
        }

        public void Register(User user, string email)
        {
            if (!_validator.IsValid(email))
            {
                throw new ArgumentException("Invalid email");
            }

            _repository.Save(user);
            _emailSender.Send(user);
        }
    }
}
