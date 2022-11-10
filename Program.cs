namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           // The main program:

           
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            
            ICommand InstallApp = new InstallCommand(receiver, "Tinder");
            ICommand UninstallApp = new UninstallCommand(receiver, "Tinder");
            ICommand OpenApp = new OpenCommand(receiver, "Tinder");
            ICommand CloseApp = new CloseAppCommand(receiver, "Tinder");
            ICommand Macro = new MacroInstallAndOpenCommand(receiver, "Facebook");

            invoker.SetInstallCommand(InstallApp);

            
            invoker.SetOpenAppCommand(OpenApp);
            invoker.SetCloseAppCommand(CloseApp);

            invoker.SetUninstallCommand(UninstallApp);

            invoker.SetMacroInstallAndOpen(Macro);
           
            invoker.CallInstall();
            invoker.CallOpen();
            invoker.CallClose();
            invoker.CallUninstall();
            invoker.CallInstallAndOpen();   
            invoker.Undo();
            invoker.Undo();



            
            

            


        }
    }
    
}