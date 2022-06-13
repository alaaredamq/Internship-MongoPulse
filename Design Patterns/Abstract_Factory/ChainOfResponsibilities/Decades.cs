namespace Abstract_Factory.Chain_of_responsibilities;

public class Decades : Handler {
    private int tens = 0;

    public override void HandleRequest(int amount) {
        while (amount >= 10) {
            tens++;
            amount -= 10;
        }
        Console.WriteLine("you get {0} x 10", tens);

        successor.HandleRequest(amount);
    }
}