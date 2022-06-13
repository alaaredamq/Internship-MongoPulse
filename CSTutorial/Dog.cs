namespace CSTutorial; 

public class Dog : Animal{
    public override void makeSound() {
        Console.WriteLine("The dog barks");
        
    }
    public override void sleep() {
        Console.WriteLine("the dog sleeps");
    }
}