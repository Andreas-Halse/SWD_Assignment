// This part of the program functions as the invoker of the command pattern

class Invoker
    {
        private ICommand? _InstallApp;

        private ICommand? _UninstallApp;


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

        public void doit()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            this._InstallApp.Execute();
            
        }

    }