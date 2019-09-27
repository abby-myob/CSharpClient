namespace Client
{
    internal static class Program
    { 
        private static void Main(){
            
            var clientOperator = new ClientOperator();
            var io = new Io(clientOperator);
            io.Start();
        }
    }

}