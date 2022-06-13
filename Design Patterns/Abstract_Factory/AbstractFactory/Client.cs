namespace Abstract_Factory;

class Client {
    private AbstractProductA _abstractProductA;
    private AbstractProductB _abstractProductB;

    public Client(AbstractFactory factory) {
        _abstractProductB = factory.CreateProductB();
        _abstractProductA = factory.CreateProductA();
    }

    public void Run() {
        _abstractProductB.Interact(_abstractProductA);
    }
}