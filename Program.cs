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

            //invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            //Receiver receiver = new Receiver();
            //invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.doit();



        }
    }
    
}