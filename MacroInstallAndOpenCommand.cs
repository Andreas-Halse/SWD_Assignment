// This is the implementation for the AppInstaller command
using System;
using HelloWorld;
class MacroInstallAndOpenCommand : ICommand
{
        ICommand installCommand;
        ICommand OpenCommand;

        // Context data, used for receiver
        private string _AppName;

      
        public MacroInstallAndOpenCommand(Receiver receiver, string AppName)
        {
           installCommand = new InstallCommand(receiver, AppName);
           OpenCommand = new OpenCommand(receiver, AppName);

        }

        // Execute command ......
        public void Execute()
        {
            Console.WriteLine("Macro begin: ");
            installCommand.Execute();
            OpenCommand.Execute();

        }

        // Undo command .........
        public void Undo()
        {
            Console.WriteLine("Macro undo: ");
            OpenCommand.Undo();
            installCommand.Undo();
        }
    }
