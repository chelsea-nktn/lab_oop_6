
using System;

class CreateAccount
{
    static void Main()
    {
        BankAccount berts = NewBankAccount(); // Создание объекта berts класса NewBankAccount
        TestDeposit(berts); // Тестирование внесения средств на аккаунт berts
        TestWithdraw(berts); // Тестирование снятия средств с аккаунта berts
        Write(berts); // Вывод данных аккаунта berts
        BankAccount freds = NewBankAccount(); // Создание объекта freds класса NewbankAccount
        TestDeposit(freds); // Тестирование внесения средств на аккаунт freds
        TestWithdraw(freds);// Тестирование снятия средств с аккаунта freds
        Write(freds); // Вывод данных аккаунта freds
    }

    static BankAccount NewBankAccount()
    {
        //long number;    
        BankAccount created = new BankAccount(); // Создание объекта created класса BankAccount

        /*Console.Write("Enter the account number: "); // Предложение ввести номер аккаунта
        long number = long.Parse(Console.ReadLine()); // Ввод номера аккаунта*/

        Console.Write("Enter the account balance!: "); //Предложение ввести баланс аккаунта
        decimal balance = decimal.Parse(Console.ReadLine()); // Ввод баланса

        /*created.accNo = number;
        created.accBal = balance;
        created.accType = AccountType.Checking;*/
        //number = created.NextNumber();
        created.Populate(balance); // Передача номера и баланса аккаунта в created

        return created; // Возврат объекта класса BankAccount
    }

    static void Write(BankAccount toWrite) // Метод Write для вывода данных объекта класса BankAccount
    {
        Console.WriteLine("Account number is {0}", toWrite.Number()); // Вывод номера аккаунта
        Console.WriteLine("Account balance is {0}", toWrite.Balance()); // Вывод баланса аккаунта 
        Console.WriteLine("Account type is {0}", toWrite.Type()); // Вывод типа аккаунта
    }
    public static void TestDeposit(BankAccount acc) // Метод TestDeposit для тестирования внесения суммы на депозит
    {
        Console.Write("Enter amount to deposit: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        acc.Deposit(amount);
    }
    public static void TestWithdraw(BankAccount acc) // Метод TestDeposit для тестирования снятия суммы на с депозита
    {
        Console.Write("Enter amount to withdraw: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        if (!acc.Withdraw(amount))
        {
            Console.WriteLine("Insufficient funds.");
        }
    }
}
