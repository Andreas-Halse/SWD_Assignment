// This part of the program functions as the invoker of the command pattern

class Invoker
{
    private ICommand? _InstallApp, _UninstallApp, _CloseApp, _OpenApp;

        
        //public Invoker(ICommand InstallApp, ICommand UninstallApp)
        //{
        //    this._InstallApp = InstallApp;
        //    this._UninstallApp = UninstallApp;
        //}

        public void ExecuteInstall(ICommand command)
        {
            this._InstallApp = command;
        }

        public void UndoUninstall(ICommand command)
        {
            this._UninstallApp = command;
        }
        
        public void CloseApp(ICommand command)
        {
            this._CloseApp = command;
        }
        public void OpenApp(ICommand command)
        {
            this._OpenApp = command;
        }

        public void CallInstall()
        {
            Console.WriteLine("Attempting to install app: ");
            this._InstallApp.Execute();
            
        }
        public void CallUninstall()
        {
            Console.WriteLine("Attempting to uninstall app: ");
            this._UninstallApp.Execute();
            
        }
        public void CallOpen()
        {
            Console.WriteLine("Attempting to open app: ");
            this._OpenApp.Execute();

        }
        public void CallClose()
        {
            Console.WriteLine("Attempting to close app: ");
            this._CloseApp.Execute();
            
        }
    
    }