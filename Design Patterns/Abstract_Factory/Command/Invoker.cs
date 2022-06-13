namespace Abstract_Factory.Command;

public class Invoker {
    Command command;

    public void SetCommand(Command command) {
        this.command = command;
    }

    public void ExecuteCommand() {
        command.Execute();
    }
}