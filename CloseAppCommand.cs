// This is the implementation for the AppInstaller command
using System;
using HelloWorld;

class CloseAppCommand : ICommand
{
        private Receiver _receiver;

        // Context data, used for receiver
        private string _AppName;

      
        public CloseAppCommand(Receiver receiver, string AppName)
        {
            this._receiver = receiver;
            this._AppName = AppName;
        }

        // Execute command ......
        public void Execute()
        {
            Console.WriteLine("AppManger: ");
            this._receiver.CloseApp(this._AppName);

        }

        // Undo command .........
        public void Undo()
        {
            Console.WriteLine("AppManger: ");
            this._receiver.OpenApp(this._AppName);
        }
    }
