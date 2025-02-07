// Author: Jason Salinas
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.
namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> productName = new List<string>();
            List<int> productQuantity = new List<int>();
            int choice;
            string product;
            int quantity;
            int totalProducts = 0;
            int totalQuantity = 0;
            string ifProduct;
            int ifProductExists;
            int updateQuantity;

            do
            {   // Menu
                Console.WriteLine("\nWelcome to the inventory Management System!");
                Console.WriteLine("Inventory Management system Menu");
                Console.WriteLine("1. Add a Product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: // Adds Products
                        Console.Write("Enter product name: ");
                        product = Console.ReadLine();

                        Console.Write("Enter product quantity: ");
                        quantity = int.Parse(Console.ReadLine());

                        productName.Add(product);
                        productQuantity.Add(quantity);
                        totalProducts ++;
                        totalQuantity += quantity;
                        break;
                    case 2: // Update Product Quantity
                        Console.Write("\nEnter product name to update product quantity: ");
                        ifProduct = Console.ReadLine();
                        ifProductExists = productName.IndexOf(ifProduct);

                        if (ifProductExists >= 0)
                        {
                            Console.Write($"Update Product Quantity: ");
                            updateQuantity = int.Parse(Console.ReadLine());

                            totalQuantity -= productQuantity[ifProductExists];
                            productQuantity[ifProductExists] = updateQuantity;
                            totalQuantity += updateQuantity;
                        }
                    
                        break;
                    case 3: // View Inventory Summary
                        Console.WriteLine("\nInventory Summary:");
                        for (int i = 0; i < productName.Count; i++)
                        {
                            Console.WriteLine($"- {productName[i]}: {productQuantity[i]}");
                        }
                        Console.WriteLine($"Total Products: {totalProducts}");
                        Console.WriteLine($"Total Quantity: {totalQuantity}");
                        Console.WriteLine($"Average Quanity: {totalQuantity / totalProducts}");
                        break;
                    case 4: // Terminate the program
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        break;
                }

            } while (choice != 4);

        }
    }
}
