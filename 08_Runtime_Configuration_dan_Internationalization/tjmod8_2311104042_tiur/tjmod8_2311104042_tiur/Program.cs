using System;

class Program
{
    static void Main(string[] args)
    {
        var config = BankTransferConfig.LoadFromFile("bank_transfer_config.json");

        Console.WriteLine(config.Lang == "id"
            ? "Masukkan jumlah uang yang akan di-transfer:"
            : "Please insert the amount of money to transfer:");

        int amount = int.Parse(Console.ReadLine());

        int fee = amount <= config.Transfer.Threshold
            ? config.Transfer.Low_fee
            : config.Transfer.High_fee;

        int total = amount + fee;

        if (config.Lang == "id")
        {
            Console.WriteLine($"Biaya transfer = {fee}");
            Console.WriteLine($"Total biaya = {total}");
            Console.WriteLine("Pilih metode transfer:");
        }
        else
        {
            Console.WriteLine($"Transfer fee = {fee}");
            Console.WriteLine($"Total amount = {total}");
            Console.WriteLine("Select transfer method:");
        }

        for (int i = 0; i < config.Methods.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {config.Methods[i]}");
        }

        int methodChoice = int.Parse(Console.ReadLine());

        Console.WriteLine(config.Lang == "id"
            ? $"Ketik \"{config.Confirmation.Id}\" untuk mengkonfirmasi transaksi:"
            : $"Please type \"{config.Confirmation.En}\" to confirm the transaction:");

        string confirmation = Console.ReadLine();

        if ((config.Lang == "id" && confirmation == config.Confirmation.Id) ||
            (config.Lang == "en" && confirmation == config.Confirmation.En))
        {
            Console.WriteLine(config.Lang == "id"
                ? "Proses transfer berhasil"
                : "The transfer is completed");
        }
        else
        {
            Console.WriteLine(config.Lang == "id"
                ? "Transfer dibatalkan"
                : "Transfer is cancelled");
        }
    }
}
