//"The specific action"
class Receiver
    {
        public void InstallApp(string app)
        {
            Console.WriteLine($"Installing the app ({app}.)");
        }
         public void UninstallApp(string app)
        {
            Console.WriteLine($"Uninstalling the app ({app}.)");
        }

        public void OpenApp(string app)
        {
            Console.WriteLine($"Openning the app ({app}.)");
        }

         public void CloseApp(string app)
        {
            Console.WriteLine($"Closing the app ({app}.)");
        }        
    }
