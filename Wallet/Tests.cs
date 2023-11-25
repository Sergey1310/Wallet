namespace Wallet;

public class Tests
{
    MyWallet _myWallet = new MyWallet();
    private void ReceiptTest(string input, decimal expected)
    {
        StringReader stringReader = new StringReader(input);
        Console.SetIn(stringReader);
        decimal result = Convert.ToDecimal(input);
        _myWallet.Receipt();
        Assert.Equal(expected, _myWallet.GetTotal());
        Console.WriteLine(_myWallet.GetTotal());
        stringReader.Dispose();
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
    }

    private void SpendingTest(string input, decimal expected)
    {
        StringReader stringReader = new StringReader(input);
        Console.SetIn(stringReader);
        decimal result = Convert.ToDecimal(input);
        _myWallet.Spending();
        Assert.Equal(expected, _myWallet.GetTotal());
        Console.WriteLine(_myWallet.GetTotal());
        stringReader.Dispose();
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
    }

    public void Test()
    {
        ReceiptTest("0", 0);
        ReceiptTest("1000", 1000);
        ReceiptTest("-100", 900);
        
        SpendingTest("0", 900);
        SpendingTest("200", 700);
        SpendingTest("-100", 800);
        
    }
}