public class UserService {
    public void setAge(int age) {
        if (age < 0) {
            throw new IllegalArgumentException("Age must be non-negative");
        }
        System.out.println("Age set to " + age);
    }
    public static void main(String[] args) {
        UserService service = new AdultUserService();
        service.setAge(10);
    }

}

class AdultUserService extends UserService {
    @Override
    public void setAge(int age) {
        super.setAge(age);

        if (age >= 18) {
            System.out.println("User is an adult");
        } else {
            System.out.println("User is a minor");
        }
    }
}
