
using System;

class CreateAccount
{
    static void Main() 
    {
        BankAccount berts = NewBankAccount(); // Создание объекта berts класса NewBankAccount
        Write(berts); // Вывод данных аккаунта berts
        
        BankAccount freds = NewBankAccount(); // Создание объекта freds класса NewbankAccount
        Write(freds);
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
        Console.WriteLine("Account number is {0}",  toWrite.Number()); // Вывод номера аккаунта
        Console.WriteLine("Account balance is {0}", toWrite.Balance()); // Вывод баланса аккаунта 
        Console.WriteLine("Account type is {0}", toWrite.Type()); // Вывод типа аккаунта
    }
}
