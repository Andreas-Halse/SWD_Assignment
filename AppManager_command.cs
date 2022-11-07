// This is the implementation for the AppInstaller command
   class AppManager : ICommand
    {
        private Receiver _receiver;

        // Context data, used for receiver
        private string _AppName;

      
        public AppManager(Receiver receiver, string AppName)
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

        // Undo command ....
        public void Undo()
        {
            this._receiver.CloseApp(this._AppName);
        }
    }
