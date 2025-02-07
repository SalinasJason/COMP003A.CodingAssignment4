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
            int choice = 0;
            string product;
            int quantity = 0;
            int totalProducts = 0;
            int totalQuantity = 0;
            string ifProduct;
            int ifProductExists;
            int updateQuantity = 0;

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
                        Console.Write("Enter product name: ");
                        product = Console.ReadLine();

                        Console.Write("Enter product quantity: ");
                        try
                        {
                            quantity = int.Parse(Console.ReadLine());
                            Console.WriteLine("Product added successfully!");
                        }
                        catch
                        {
                            Console.WriteLine("Invaild input, Please enter a valid number");

                        }

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
                            try
                            {
                                updateQuantity = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Invaild input, Please enter a valid number");
                            }

                            totalQuantity -= productQuantity[ifProductExists];
                            productQuantity[ifProductExists] = updateQuantity;
                            totalQuantity += updateQuantity;
                        }
                        else
                            Console.WriteLine("Product not found, Please try again");
                    
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
                        Console.WriteLine("Invaild input, choose between 1-4");
                        break;
                }

            } while (choice != 4);

        }
    }
}
