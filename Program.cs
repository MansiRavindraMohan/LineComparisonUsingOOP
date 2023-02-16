namespace LineComparisonUsingOOP
{
    class Program
    {
        public void EqualityofLines()
            {
                int val1;
                int val2;
                int val3;
                int val4;
                int val5;
                int val6;
                int val7;
                int val8;

                Console.WriteLine("Enter the first line");
                Console.WriteLine("Enter the start point");

                Console.WriteLine("Enter x1: ");
                val1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y1: ");
                val2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the end point");

                Console.WriteLine("Enter x2: ");
                val3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y2: ");
                val4 = Convert.ToInt32(Console.ReadLine());

                double length = Math.Sqrt((val3 - val1) ^ 2 + (val4 - val2) ^ 2);
                Console.WriteLine("Length of first line is:" + length);

                Console.WriteLine("Enter the second line");
                Console.WriteLine("Enter the start point");

                Console.WriteLine("Enter x1: ");
                val5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y1: ");
                val6 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the end point");

                Console.WriteLine("Enter x2: ");
                val7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y2: ");
                val8 = Convert.ToInt32(Console.ReadLine());

                double length1 = Math.Sqrt((val7 - val5) ^ 2 + (val8 - val6) ^ 2);
                Console.WriteLine("Length of second line is:" + length1);

                if (length.Equals(length1))
                {
                    Console.WriteLine("Lines are equal");
                }
                else
                {
                    Console.WriteLine("Lines are not equal");
                }
        }
        static void Main(string[] args)
        {
            Program lineequality = new Program();
            lineequality.EqualityofLines();
        }
    }
   
}

 