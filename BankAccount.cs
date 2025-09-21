using System.Runtime.InteropServices;

class BankAccount //Класс BankAccount, описывающий объект банковского аккаунта
{
    private long accNo; // Приватное поле номера аккаунта
    private decimal accBal; // Приватное поле баланса аккаунта
    private AccountType accType; // Приватное поле типа аккаунта
    private static long nextAccNo = 123; // Приватное статическое поле номера аккаунта (изначально равное 123)
    public void Populate(decimal balance) // Метод Populate, заполняющий поля аккаунта 
    {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }
    public long Number() // Метод Number, возвращающий номер аккаунта
    {
        return accNo;
    }
    public decimal Balance() // Метод Balance, возвращающий баланс аккаунта
    {
        return accBal;
    }
    public string Type() // Метод Type, возвращающий тип аккаунта
    {
        return accType.ToString();
    }
    private long NextNumber() // Метод NextNumber, возвращающий следующий номер аккаунта через nextAccNo
    {
        return nextAccNo++;
    }

}
