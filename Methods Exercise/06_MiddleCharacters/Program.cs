namespace _06_MiddleCharacters
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            /*
              You will receive a single string. Create a method that prints the character found at its middle. If the length of the
              string is even, there are two middle characters.
            */

            string input = Console.ReadLine();
            char[] inputArr = input.ToCharArray();
            GetMiddleElement(inputArr);


        }

        

        static void GetMiddleElement(char[] arr)
        {
            char middleChar = ' ';
            char middleChar2 = ' ';
            
                if (arr.Length % 2 != 0)
                {
                    for (int i = 1; i <= arr.Length; i++)
                    {
                        middleChar = arr[i / 2];
                        
                    }
                    Console.WriteLine(middleChar);
                }
                else
                {
                    for (int i = 1; i <= arr.Length ; i++)
                    {
                        i++;

                        middleChar = arr[(i / 2) - 1];
                        middleChar2 = arr[(i / 2)];
                        
                    }
                    Console.Write($"{middleChar}{middleChar2}");
                }
            
        }
    }
}