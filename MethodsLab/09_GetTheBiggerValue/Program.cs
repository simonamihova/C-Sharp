namespace _09_GetTheBiggerValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();  
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();
            string result = "";
            switch(valueType)
            {
                case "int":
                    result = ($"{GetGreaterInt(int.Parse(value1),int.Parse(value2))}");
                    break;
                case "string":
                    result = ($"{GetGreaterString( value1, value2)}");
                    break;
                case "char":
                    result = ($"{GetGreaterChar(char.Parse(value1), char.Parse(value2))}");
                    break;
            }
            Console.WriteLine( result );
        }
         static int GetGreaterInt(int value1, int value2)
        {
            int result = Math.Max(value1, value2);
            return result;
        }
        static char GetGreaterChar(char value1, char value2)
        {
            if (value1 > value2)
            {
                return value1;
            }
            else
            {
                return value2;  
            }
        }
        static string GetGreaterString(string value1, string value2)
        {
            if(string.Compare(value1, value2) == 1)
            {
                return value1;
            }
            else 
            {
                return value2; 
            } 
        }
    }
}