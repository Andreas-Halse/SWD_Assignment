namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           // The main program:

           
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();

            invoker.ExecuteInstall(new AppInstaller(receiver, "Tinder"));

            //invoker.CallInstall();
            
            invoker.CallOpen();



        }
    }
    
}