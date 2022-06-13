namespace Abstract_Factory.Chain_of_responsibilities; 

public class Hundreds : Handler {
    private int hundreds = 0;
    public override void HandleRequest(int amount) {
        while (amount >= 100) {
            hundreds++;
            amount -= 100;
        }
        Console.WriteLine("you get {0} x 100", hundreds);
        successor.HandleRequest(amount);
    }
}