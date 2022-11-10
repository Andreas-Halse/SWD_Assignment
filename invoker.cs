// This part of the program functions as the invoker of the command pattern
using HelloWorld;
using System.Linq;

class Invoker
{
    private ICommand? _InstallApp, _UninstallApp, _CloseApp, _OpenApp, _MacroInstallAndOpen;
    private List<ICommand> _CommandBuffer = new List<ICommand>();
    
        
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

        public void SetMacroInstallAndOpen(ICommand command)
        {
            this._MacroInstallAndOpen= command;
        }

        public void CallInstall()
        {
            this._InstallApp.Execute();
            _CommandBuffer.Add(_InstallApp);
        }
        public void CallUninstall()
        {
            this._UninstallApp.Execute();
            _CommandBuffer.Add(_UninstallApp);
        }
        public void CallOpen()
        {
            this._OpenApp.Execute();
            _CommandBuffer.Add(_OpenApp);
        }
        public void CallClose()
        {
            this._CloseApp.Execute();
            _CommandBuffer.Add(_CloseApp);
        }

        public void CallInstallAndOpen()
        {
            this._MacroInstallAndOpen.Execute();

            _CommandBuffer.Add(_MacroInstallAndOpen);
        }

        public void Undo()
        {
            if(_CommandBuffer.Count>0)
            {
                ICommand undoCommand = _CommandBuffer.Last();

                undoCommand.Undo();
                _CommandBuffer.RemoveAt(_CommandBuffer.Count-1);
            }

        }
}