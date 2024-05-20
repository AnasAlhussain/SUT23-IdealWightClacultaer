namespace SUT23_IdealWightClacultaer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeightCalculater weight = new WeightCalculater()
            {
                Height = 180,
                Gender = 'm'
            };

            double result = weight.GetIdealBodyWeight();
            Console.WriteLine($"The Total body weight is : {result}");


            if(result == 72.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Succeded");
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;

                Console.WriteLine("Test Failed");
            }

            Console.WriteLine("---- Test Ideal Weight Women");
            weight.Gender = 'w';
            result = weight.GetIdealBodyWeight();
            if (result == 72.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Succeded");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Test Failed");
            }

            Console.ReadKey();
        }
    }
}
