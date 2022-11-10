// This is the implementation for the AppInstaller command
   class OpenCommand : ICommand
    {
        private Receiver _receiver;

        // Context data, used for receiver
        private string _AppName;

      
        public OpenCommand(Receiver receiver, string AppName)
        {
            this._receiver = receiver;
            this._AppName = AppName;
        }

        // Execute command ......
        public void Execute()
        {
            Console.WriteLine("AppManger: ");
            this._receiver.OpenApp(this._AppName);
            
        }

        // Undo command .........
        public void Undo()
        {
            Console.WriteLine("AppManger: ");
            this._receiver.CloseApp(this._AppName);
        }
    }
