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
            invoker.CallInstall();

            
            invoker.SetOpenAppCommand(OpenApp);
            invoker.CallOpen();
            invoker.SetCloseAppCommand(CloseApp);
            invoker.CallClose();

            invoker.SetUninstallCommand(UninstallApp);
            invoker.CallUninstall();

            invoker.SetMacroInstallAndOpen(Macro);
            invoker.CallInstallAndOpen();   
           

            
            

            


        }
    }
    
}