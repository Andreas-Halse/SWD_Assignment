// This functions as the interface for the command pattern
using HelloWorld;
  public interface ICommand
    {
        void Execute();
        void Undo();
    }