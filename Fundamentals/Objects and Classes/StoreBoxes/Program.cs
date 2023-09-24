namespace StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
 

           while (true) 
           {
                
                string input = Console.ReadLine();
                if(input == "end")
                {
                    break;
                }

                string[] boxDataArr = input.Split(" ").ToArray();

                string boxSerialNum = boxDataArr[0];
                string itemName = boxDataArr[1];
                int itemQuantity = int.Parse(boxDataArr[2]);
                decimal itemPrice = decimal.Parse(boxDataArr[3]);

                Box box = new Box();
                box.SerialNumber = boxSerialNum;
                Item item = new Item();
                item.Name = itemName;
                item.Price = itemPrice;
                box.ItemProp = item;
                box.Quantity = itemQuantity;
                box.PriceBox = itemQuantity * itemPrice;
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {item.Name} – ${item.Price}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:F2}");

            }




        }
    }

    class Item
    {
        public String Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item ItemProp { get; set; }
        public int Quantity { get; set; }   
        public decimal PriceBox { get; set; }   

    }
}