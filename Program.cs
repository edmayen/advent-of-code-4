using System;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            int init = 372304;
            Console.WriteLine("_______________________");
            Console.WriteLine("Day 4: Secure Container");
            Console.WriteLine("_______________________");
            total = getPass(init);
            Console.WriteLine("\nExists " + total + " different passwords.");
        }

        public static int getPass(int init)
        {
            int total = 0;
            int[] array = new int[6];
            do{
                array = intToArray(init);
                if(array.Length > 0 && array.Length < 7)
                {
                    if(array[0] == array[1] || array[1] == array[2] || array[2] == array[3] || array[3] == array[4] || array[4] == array[5])
                    {
                        if(array[0] <= array[1])
                        {
                            if(array[1] <= array[2])
                            {
                                if(array[2] <= array[3])
                                {
                                    if(array[3] <= array[4])
                                    {
                                        if(array[4] <= array[5])
                                        {
                                            total+=1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                init+=1;
            }while(init <= 847060);
            return total;
        }

        public static int[] intToArray(int num)
        {
            var result = new int[6];
            for(int i = result.Length - 1; i >= 0; i--)
            {
                result[i] = num % 10;
                num /= 10;
            }
            return result;
        }
    }
}
