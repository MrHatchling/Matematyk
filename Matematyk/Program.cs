namespace Matematyk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double num = rnd.Next(0, 16);
            double num2 = rnd.Next(0, 10);            
            double correct = 0;

            switch (rnd.Next(0, 4)) 
            {
                case 0:
                    Console.Write($"{num} + {num2} = ");
                    correct = num + num2;
                    break;
                case 1:
                    Console.Write($"{num} - {num2} = ");
                    correct = num - num2;
                    break;
                case 2:
                    Console.Write($"{num} * {num2} = ");
                    correct = num * num2;
                    break;
                case 3:
                    num2 = rnd.Next(1, 3);
                    Console.Write($"{num} / {num2} = ");
                    correct = num / num2;
                    break;
            }

            string res = Console.ReadLine();
            double result = Convert.ToDouble(res);

            if (result == correct) 
            {
                Console.WriteLine("You are right, my man!");
            }
            else
            {
                Console.WriteLine("You are wrong, you idiot!");
            }
        }
    }
}
