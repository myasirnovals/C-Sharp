namespace Latihan13;

public class InterfaceImpl
{
    public static void Main()
    {
        Cat cat = new Cat();
        cat.eat();
        cat.walk();
        cat.sleep();

        Dog dog = new Dog();
        dog.eat();
        dog.walk();
        dog.sleep();
    }
}