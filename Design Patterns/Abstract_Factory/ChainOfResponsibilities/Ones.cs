namespace Abstract_Factory.Chain_of_responsibilities;

public class Ones : Handler {
    private int ones = 0;

    public override void HandleRequest(int amount) {
        while (amount >= 1) {
            ones++;
            amount -= 1;
        }

        Console.WriteLine("you get {0} x 1", ones);
    }
}