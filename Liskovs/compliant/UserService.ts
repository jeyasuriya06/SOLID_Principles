class UserService {
  setAge(age: number) : void {
    if (age < 0) {
      throw new Error("Age must be  non-negative");
    }
    console.log("Age set to " + age);
  }
}

class AdultUserService extends UserService {
  override setAge(age: number) : void {
    super.setAge(number);
    if (age >= 18) {
      console.log("user is an adult");
    } else {
      console.log("user is a minor");
  }
}
