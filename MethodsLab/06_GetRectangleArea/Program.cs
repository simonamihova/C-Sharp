namespace _06_GetRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height =  int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int area = GetRectangleArea(height, width);
            Console.WriteLine(area);

        }
        static int GetRectangleArea(int height, int width)
        {
            int area = height * width;
            return area;
        } 
    }
}