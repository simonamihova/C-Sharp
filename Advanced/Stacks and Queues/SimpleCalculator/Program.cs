namespace SimpleCalculator
{
    internal class Program
    {
        static void Main()
        {
            string[] inputArr = Console.ReadLine().Split(' ').ToArray();
            Stack<string> revExpression = new Stack<string>();
            
            for(int i = inputArr.Length; i > 0; i--)
            {
                revExpression.Push(inputArr[i]);
            }

            int result = int.Parse(revExpression.Pop());


            while (revExpression.Count > 0)
            {
                char mathOperator;
                int number;
                bool isNumber = false;
               //var typeItem = revExpression.Peek().GetType();
                string currentItem = revExpression.Pop();

                /*if (currentItem.GetType == typeof(char))
                {
                    mathOperator = Char.Parse(revExpression.Pop());
                }
                if (typeItem == typeof(int)) 
                {
                    number = 
                }*/




            }
        }
    }
}