namespace Abstract_Factory.Chain_of_responsibilities;

public class Fives : Handler {
    private int fives = 0;

    public override void HandleRequest(int amount) {
        while (amount >= 5) {
            fives++;
            amount -= 5;
        }
        Console.WriteLine("you get {0} x 5", fives);

        successor.HandleRequest(amount);
    }
}