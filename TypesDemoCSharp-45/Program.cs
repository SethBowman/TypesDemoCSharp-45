namespace TypesDemoCSharp_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is comment

            //Variables

            //type - name - value

            //Number types

            int? sethsAge = null;

            double average = 99.80;

            decimal cash = 500.00m;

            //Word types

            string greeting = "Hello my name is Seth";

            char initial = 'S';

            //Fact type

            bool isAlive = true;

            //Value and Ref types section

            //Value types

            int a = 1;
            int b = a;

            a = 500;

            Console.WriteLine(a);
            Console.WriteLine(b);

            //Reference

            Point p1 = new Point();

            p1.X = 1;

            Point p2 = p1;

            p2.X = 500;

            Console.WriteLine(p1.X);
            Console.WriteLine(p2.X);


            //Signed
            int numOne = -12;
            //Unsigned
            int numTwo = 4;



        }
    }
}
