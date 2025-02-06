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
            List<string> list = new List<string>();
            List<int> list2 = new List<int>();
            int choice;

            Console.WriteLine("Welcome to the inventory Management System!");
            Console.WriteLine("Inventory Management system Menu");
            Console.WriteLine("1. Add a Product");
            Console.WriteLine("2. Update Product Quantity");
            Console.WriteLine("3. View Inventory Summary");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

        }
    }
}
