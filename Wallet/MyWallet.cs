namespace Wallet;

public class MyWallet
{
    private decimal total;

    public MyWallet() : this(0) {}
    public MyWallet(decimal Total)
    {
        total = Total;
    }

    public void Receipt()
    {
        PrintLine();
        Console.Write("Enter the amount of the receipt: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());
        total += amount;
        PrintLine();
    }

    public void Spending()
    {
        PrintLine();
        Console.Write("Enter the amount of the spending: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());
        total -= amount;
        PrintLine();
    }

    public void ShowBalance()
    {
        PrintLine();
        Console.WriteLine($"Your balance: {total}");
        PrintLine();
    }

    private void PrintLine()
    {
        Console.WriteLine("------------------------------------------------");
    }

    public decimal GetTotal()
    {
        return total;
    }
}