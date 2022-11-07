// This functions as the interface for the command pattern

  public interface ICommand
    {
        void Execute();
        void Undo();
    }