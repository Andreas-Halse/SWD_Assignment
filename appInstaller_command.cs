// This is the implementation for the AppInstaller command
   class AppInstaller : ICommand
    {
        private Receiver _receiver;

        // Context data, used for receiver
        private string _AppName;

      
        public AppInstaller(Receiver receiver, string AppName)
        {
            this._receiver = receiver;
            this._AppName = AppName;
        }

        // Execute command ......
        public void Execute()
        {
            Console.WriteLine("AppInstaller: ");
            this._receiver.InstallApp(this._AppName);
            
        }

        // Undo command ....
        public void Undo()
        {
            this._receiver.UninstallApp(this._AppName);
        }
    }
