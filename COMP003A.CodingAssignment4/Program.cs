// Author: Jason Salinas
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.
namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static List<string> productName = new List<string>();
        static List<int> productQuantity = new List<int>();
        static int totalQuantity;
        static void Main(string[] args)
        {

            int choice = 0;
            Console.WriteLine("Welcome to the inventory Management System!");

            do
            {   // Menu
                Console.WriteLine("\nInventory Management system Menu");
                Console.WriteLine("1. Add a Product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Invaild input, Please enter a vaild number");
                }


                switch (choice)
                {
                    case 1: // Adds Products
                        AddProducts();
                        break;
                    case 2: // Update Product Quantity
                        UpdateProductQuantity();
                        break;
                    case 3: // View Inventory Summary
                        ViewInventory();
                        break;
                    case 4: // Terminate the program
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Invaild input, choose between 1-4");
                        break;
                }

            } while (choice != 4);

        }

        static void AddProducts()
        {
            Console.Write("Enter product name: ");
            string product = Console.ReadLine();

            Console.Write("Enter product quantity: ");
            try
            {
               int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Product added successfully!");
                productName.Add(product);
                productQuantity.Add(quantity);
            }
            catch
            {
                Console.WriteLine("Invaild input, Please enter a valid number");

            }

            

        }

        static void UpdateProductQuantity()
        {
            Console.Write("\nEnter product name to update product quantity: ");
           string ifProduct = Console.ReadLine();
            int ifProductExists = productName.IndexOf(ifProduct);

            if (ifProductExists >= 0)
            {
                Console.Write($"Update Product Quantity: ");
                try
                {
                   int updateQuantity = int.Parse(Console.ReadLine());
                    totalQuantity -= productQuantity[ifProductExists];
                    productQuantity[ifProductExists] = updateQuantity;
                    totalQuantity += updateQuantity;
                }
                catch
                {
                    Console.WriteLine("Invaild input, Please enter a valid number");
                }


            }
            else
            {
                Console.WriteLine("Product not found, Please try again");
            }
        }

        static void ViewInventory()
        {
            Console.WriteLine("\nInventory Summary:");
            totalQuantity = 0;

            for (int i = 0; i < productName.Count; i++)
            {
                Console.WriteLine($"- {productName[i]}: {productQuantity[i]}");
                totalQuantity += productQuantity[i];
            }
            Console.WriteLine($"Total Products: {productName.Count}");
            Console.WriteLine($"Total Quantity: {totalQuantity}");
            Console.WriteLine($"Average Quanity: {totalQuantity / productName.Count}");
        }
    }
}
