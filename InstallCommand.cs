// This is the implementation for the AppInstaller command
using HelloWorld;   
class InstallCommand : ICommand
    {
        private Receiver _receiver;

        // Context data, used for receiver
        private string _AppName;

      
        public InstallCommand(Receiver receiver, string AppName)
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
            Console.WriteLine("AppInstaller: ");
            this._receiver.UninstallApp(this._AppName);
        }
    }
