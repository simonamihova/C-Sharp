using System.Text.RegularExpressions;


namespace AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(#|\|)([a-zA-Z\s]+)(\1)(\d{2}/\d{2}/\d{2})(\1)(\d+)(\1)";

            MatchCollection matches = Regex.Matches(input, pattern);


            List<Product> products = new List<Product>();

            foreach (Match match in matches)
            {
                string itemName = match.Groups[2].Value;
                string expirationDate = match.Groups[4].Value;
                int calories = int.Parse(match.Groups[6].Value);
                products.Add(new Product(itemName, expirationDate, calories));
            }

            int daysToSurvive = products.Sum(x=>x.Nutrition)/2000;

            Console.WriteLine($"You have food to last you for: {daysToSurvive} days!");
            
            foreach(Product product in products)
            {
                Console.WriteLine($"Item: {product.Name}, Best before: {product.ExpirationDate}, Nutrition: {product.Nutrition}");
            }
        }

        class Product
        {

            public Product(string name, string expirationDate, int nutrition)
            {
                Name = name;
                ExpirationDate = expirationDate;
                Nutrition = nutrition;
            }

            public string Name { get; set; }

            public string ExpirationDate { get; set; }

            public int Nutrition { get; set; }
        }
    }

}