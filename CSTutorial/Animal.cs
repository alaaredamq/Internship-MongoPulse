namespace CSTutorial; 

public class Animal {
    private String name;
    private int age;
    public static int animalCount = 0;

    public Animal(string name, int age) {
        this.name = name;
        this.age = age;
        animalCount++;
    }

    public Animal() {
        animalCount++;
    }

    public string getName() {
        return name;
    }

    public void setName(string name) {
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public virtual void makeSound() {
        Console.WriteLine("make animal sounds");
    }

    public virtual void sleep() {
        Console.WriteLine("the animal sleeps");
    }
    public void eat(){}
}