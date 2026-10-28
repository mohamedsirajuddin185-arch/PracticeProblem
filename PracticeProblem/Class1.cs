namespace PracticeProblem
{
    public class Class1
    {
        //public static void Main()
        //{
        //    bool number = (IsEven(7));
        //    Console.WriteLine(number);

        //}
        //public static bool IsEven(int number)
        //{
        //    if (number % 2 == 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        //public static void Main()
        //{
        //    bool number = (IsEven(7));
        //    Console.WriteLine(number);
        //}
        //public static bool IsEven(int number)
        //{
        //    if(number % 2 == 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        //Find Largest Number
        //public static void Main()
        //{
        //    Console.WriteLine(FindLargest(14, 32, 9)); 
        //}
        //public static int FindLargest(int a, int b, int c)
        //{
        //    if(a > b && a >= c)
        //    {
        //        return a;
        //    }
        //    else if(b >= a && b >= c)
        //    {
        //        return b;
        //    }
        //    else
        //    {
        //        return c;
        //    }
        //}


        //public static void Main()
        //{
        //    int[] number = { 10, 20, 22, 33, 11, 40, 50 };
        //    int result = FindLargest(number);
        //    Console.WriteLine(result);
        //}
        
        //public static int FindLargest(int[] number)
        //{
        //    int largest = number[0];
        //    foreach(int num in number)
        //    {
        //        if (num > largest)
        //        {
        //            largest = num;
        //        }
        //    }
        //    return largest;
        //}


        //Claculate Grade

        //public static void Main()
        //{
        //    Console.WriteLine("Enter the Marks : ");
        //    int marks = Convert.ToInt32(Console.ReadLine());

        //    if (marks <= 0 && marks > 100)
        //    {
        //        Console.WriteLine("Invalid Marks");
        //    }
        //    else if (marks >= 90 && marks <= 100)
        //    {
        //        Console.WriteLine("Grade A");
        //    }
        //    else if (marks >= 75 && marks < 90)
        //    {
        //        Console.WriteLine("Grade B");
        //    }
        //    else if (marks >= 60 && marks < 75)
        //    {
        //        Console.WriteLine("Grade C");
        //    }
        //    else if (marks >= 40 && marks < 60)
        //    {
        //        Console.WriteLine("Just Pass");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Fail");
        //    }
        //}


        //Revercing numbers

        //public static void Main()
        //{
        //    Console.WriteLine(ReverseNumber(1234));
        //    Console.ReadKey();
        //}
        //public static int ReverseNumber(int number)
        //{
        //    int reversed = 0;
        //    while(number > 0)
        //    {
        //        int lastNum = number % 10;
        //        reversed = reversed * 10 + lastNum;
        //        number = number / 10;
        //    }
        //    return reversed;
        //}

        //public static void Main()
        //{
        //    Console.WriteLine(ReverseNumber(6789));
        //    Console.ReadKey();
        //}
        //public static int ReverseNumber(int number)
        //{
        //    int reversed = 0;
        //    while(number >0)
        //    {
        //        int lastNum = number % 10;
        //        reversed = reversed * 10 + lastNum;
        //        number = number / 10;
        //    }
        //    return reversed;
        //}

        //Factorial Number
        //5! = 5*4*3*2*1* = 120
        //public static void Main()
        //{
        //    Console.WriteLine(Factorial(5));
        //    Console.ReadKey();
        //}
        //public static int Factorial(int number)
        //{
        //    int factorial = 1;
        //    for(int i = 1; i <= number; i++)
        //    {
        //        factorial = factorial * i;
        //    }
        //    return factorial;
        //}


        //Remove Duplicate

        //public static void Main()
        //{
        //    int[] number = { 4, 2, 4, 3, 2, 1 };
        //    int[] result = RemoveDuplicate(number);

        //    foreach(int n in result)
        //    {
        //        Console.Write(n + " ");
        //    }
           
        //}
        //public static int[] RemoveDuplicate(int[] number)
        //{
        //    List<int> result = new List<int>();

        //    foreach(int n in number)
        //    {
        //        if (!result.Contains(n))
        //        {
        //            result.Add(n);
        //        }
        //    }
        //    return result.ToArray();
        //}

        //public static void Main()
        //{
        //    int[] number = { 4, 2, 4, 3, 2, 1 };
        //    int[] result = RemoveDuplicate(number);

        //    foreach(int n in result)
        //    {
        //        Console.WriteLine(n + " ");
        //    }

        //}
        //public static int[] RemoveDuplicate(int[] number)
        //{
        //    List<int> result = new List<int>();
        //    foreach(int n in number)
        //    {
        //        if (!result.Contains(n)) ;
        //        {
        //            result.Add(n);
        //        }
        //    }
        //    return result.ToArray();
        //}


        //Reversed number
        //public static void Main()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6 };

        //    for(int i = numbers.Length -1; i >=0; i--)
        //    {
        //        Console.WriteLine(numbers[i]);
        //    }
        //}

        //public static void Main()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5 };

        //    for(int i = numbers.Length - 1; i >= 0; i--)
        //    {
        //        Console.WriteLine(numbers[i]);
        //    }
        //}
          


        //Finding average
        public static void Main()
        {
            int[] numbers = { 10, 0, 20, 0, 30 };
            double result = FindAverage(numbers);
            Console.WriteLine(result);
        }
        public static int FindAverage(int[] numbers)
        {
            int sum = 0;
            int count = 0;

            foreach (int num in numbers)
            {
                if (num != 0)
                {
                    sum += num;
                    count++;
                }
            }
            if (count == 0)
            {
                return 0;
            }
            return sum / count;

        }
    }
}
