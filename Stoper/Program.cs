namespace Stoper
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stoper stoper = new Stoper();


            while (true) 
            {
                {
                    Console.WriteLine("--STOPER--");
                    Console.WriteLine("Wciśnij 'x' - START, 'y' -STOP, '0' - RESET");
                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "x":
                            stoper.Start();
                            break;
                        case "y":
                            stoper.Stop();
                            break;
                        case "0":
                            stoper.Reset();
                            break;
                        default:
                            Console.WriteLine("spróbuj ponownie!");
                            break;


                    };
                    stoper.Display();
                }
            }
            
            


        }
    }
}
