using semaine3.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        NorthwindContext context = new NorthwindContext();

        Console.WriteLine("Entrez une ville.");
        string ville = Console.ReadLine();

        if (ville == null) return;

        Customer[] cust = (from c in context.Customers
                           where c.City == ville
                           select c).ToArray();
    }
}