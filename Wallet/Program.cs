using Wallet;

/*MyWallet myWallet = new MyWallet();
int choice = 0;
while (choice != 4)
{
    {
        Console.Write("Chose option:\n" +
                      "1) Show balance.\n" +
                      "2) Receipt.\n" +
                      "3) Spending\n" +
                      "4) Exit.\n" +
                      "Your enter: ");
        choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                myWallet.ShowBalance();
                break;
            case 2:
                myWallet.Receipt();
                break;
            case 3:
                myWallet.Spending();
                break;
            case 4:
                break;
            default:
                Console.WriteLine("Incorrect choice, try again.");
                break;
        }
    }
}*/

Tests tests = new Tests();
tests.Test();