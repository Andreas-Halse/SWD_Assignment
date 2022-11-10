// This part of the program functions as the invoker of the command pattern
using HelloWorld;

class Invoker
{
    private ICommand? _InstallApp, _UninstallApp, _CloseApp, _OpenApp;

        
        //public Invoker(ICommand InstallApp, ICommand UninstallApp)
        //{
        //    this._InstallApp = InstallApp;
        //    this._UninstallApp = UninstallApp;
        //}

        public void SetInstallCommand(ICommand command)
        {
            this._InstallApp = command;
        }

        public void SetUninstallCommand(ICommand command)
        {
            this._UninstallApp = command;
        }
        
        public void SetCloseAppCommand(ICommand command)
        {
            this._CloseApp = command;
        }
        public void SetOpenAppCommand(ICommand command)
        {
            this._OpenApp = command;
        }

        public void CallInstall()
        {
            this._InstallApp.Execute();
        }
        public void CallUninstall()
        {
            this._UninstallApp.Undo();
        }
        public void CallOpen()
        {
            this._OpenApp.Execute();
        }
        public void CallClose()
        {
            this._CloseApp.Undo();
        }
    
    }