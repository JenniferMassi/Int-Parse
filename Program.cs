namespace Halloween
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Userinput = "";
            int number = 0;

            Console.Write("How old are you? ");
            Userinput = Console.ReadLine();
          
            number = int.Parse(Userinput);
            Console.WriteLine("You will be " + (number + 15 ) + " in 15 years");


        }
    }
}