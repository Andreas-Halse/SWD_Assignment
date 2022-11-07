// This part of the program functions as the invoker of the command pattern

class Invoker
    {
        private ICommand _InstallApp;

        private ICommand _UninstallApp;


        public Invoker(ICommand InstallApp, ICommand UninstallApp)
        {
            this._InstallApp = InstallApp;
            this._UninstallApp = UninstallApp;
        }


        // Initialize commands.
        public void SetOnStart(ICommand command)
        {
            this._InstallApp = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this._onFinish = command;
        }
    }