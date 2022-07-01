using System;

namespace AssessmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============Question 1=============");
            Console.WriteLine("Enter the first number");
            int integer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int integer2 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int c = integer1; c <= integer2; c++);
            {
                if (c % 5 == 0);
                {
                    Console.WriteLine(c);
                    count++;
                }
                
            }
            Console.WriteLine(count.ToString());
            Console.WriteLine("=============== Question 2 ==============");
            int n = 100;
                int f1 = 0, f2 = 1, i;

            if (n < 1)
            return;
            for (i = 1; i < n; i++)
            {
                Console.Write(f2 + " ");
                int next = f1 + f2;
                f1 = f2;
                f2 = next;
            }
            Console.WriteLine("=============Question 5=============");
            Console.WriteLine("Enter any number from 0-9");
            String number = Console.ReadLine();
            switch(number)
            {
                case "1":
                Console.WriteLine(1*10);
                break;
                case "2":
                Console.WriteLine(2*10);
                break;
                case "3":
                Console.WriteLine(3*10);
                break;
                case "4":
                Console.WriteLine(4*100);
                break;
                case "5":
                Console.WriteLine(5*100);
                break;
                case "6":
                Console.WriteLine(6*100);
                break;
                case "7":
                Console.WriteLine(7*1000);
                break;
                case "8":
                Console.WriteLine(8*1000);
                break;
                case "9":
                Console.WriteLine(9*1000);
                break;

                default: 
                Console.WriteLine("Invalid digit, input a valid one"); 
                break;
            }
            Console.WriteLine("================ Question 6 =================");
            Console.WriteLine("Enter any number");
            int length = int.Parse(Console.ReadLine());

            for (int i = 1; i < length; i++);
            {
                if (i % (3 * 7) != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("================ Question 7 =================");
            for (int i = 0; i < 4; i++);
            {
                if (a = 0; a < 13; a++;)
                {
                    switch (i)
                    {
                        case 0: Console.Write("Club "); 
                        break;
                        case 1: Console.Write("Diamond "); 
                        break;
                        case 2: Console.Write("Heart "); 
                        break;
                        case 3: Console.Write("Spades "); 
                        break;
                    }
                    switch (a)
                    {
                        case 0: Console.WriteLine("2"); 
                        break;
                        case 1: Console.WriteLine("3"); 
                        break;
                        case 2: Console.WriteLine("4"); 
                        break;
                        case 3: Console.WriteLine("5"); 
                        break;
                        case 4: Console.WriteLine("6"); 
                        break;
                        case 5: Console.WriteLine("7"); 
                        break;
                        case 6: Console.WriteLine("8"); 
                        break;
                        case 7: Console.WriteLine("9"); 
                        break;
                        case 8: Console.WriteLine("10"); 
                        break;
                        case 9: Console.WriteLine("J"); 
                        break;
                        case 10: Console.WriteLine("Q"); 
                        break;
                        case 11: Console.WriteLine("K"); 
                        break;
                        case 12: Console.WriteLine("A"); 
                        break;
                    }
                }
            }
            Console.WriteLine("================ Question 10 =================");
            int [] num = new int[20];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i * 5;
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("================ Question 14 =================");
            Console.WriteLine("Enter any binary number");
            String binaryNum = Convert.ToString(Console.ReadLine());
            int decValue = Convert.ToInt32(binaryNum, 2);
            Console.WriteLine($"The result of the conversion is {decValue}");
            Console.WriteLine("================ Question 15 =================");
            Console.WriteLine("Enter any decimal number");
            String decimalVal = Convert.ToString(Console.ReadLine());
            int binaryVal = Convert.ToInt32(decimalVal, 10);
            String convertBin = Convert.ToString(binaryVal, 2);
            Console.WriteLine($"The result of the conversion is {convertBin}");
            Console.WriteLine("================ Question 16 =================");
            Console.WriteLine("Enter any decimal number: ");
            int d = int.Parse(Console.ReadLine());
            String toDec = Convert.ToString(d, 10);
            String hexDec = Convert.ToString(d, 16);
            Console.WriteLine($"The result of the conversion is {hexDec}");
            Console.WriteLine("================ Question 17 =================");
            Console.WriteLine("Enter a hexadecimal number");
            string hexadecimal = Convert.ToString(Console.ReadLine());
            int decimalValue = Convert.ToInt32(hexadecimal, 16);
            Console.WriteLine(decimalValue);
            Console.WriteLine("================ Question 18 =================");
            Console.WriteLine("Enter any hexadecimal number");
            String hexDec = Convert.ToString(Console.ReadLine());
            int decVal = Convert.ToInt32(hexDec, 16);
            Console.WriteLine(decVal);
            string convertToBinary = Convert.ToString(decVal, 2);
            Console.WriteLine(convertToBinary);
            Console.WriteLine("================ Question 19 =================");
            Console.WriteLine("Enter a binary number");
            string binaryNumber = Convert.ToString(Console.ReadLine());
            int decimalValue = Convert.ToInt32(binaryNumber, 2);
            Console.WriteLine(decimalValue);
            String hexDecimal = Convert.ToString(decimalValue, 16);
            Console.WriteLine(hexDecimal);
            Console.WriteLine("================ Question 20 =================");
            int[,] matrix =
            {
                {1, 5, 9, 13}, 
                {2, 6, 10, 14},
            };
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
            }

        }
    }
}
