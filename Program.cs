namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           // The main program:

           
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            
            ICommand InstallApp = new AppInstaller(receiver, "AppInstaller");
            ICommand UninstallApp = new UninstallCommand(receiver, "UninstallCommand");
            ICommand OpenApp = new OpenAppCommand(receiver, "OpenAppCommand");
            ICommand CloseApp = new CloseAppCommand(receiver, "CloseAppCommand");

            invoker.SetInstallCommand(InstallApp);
            invoker.CallInstall();
            
            invoker.SetUninstallCommand(UninstallApp);
            invoker.CallOpen();
            
            invoker.SetOpenAppCommand(OpenApp);
            invoker.CallClose();
            
            invoker.SetCloseAppCommand(CloseApp);
            invoker.CallUninstall();


        }
    }
    
}