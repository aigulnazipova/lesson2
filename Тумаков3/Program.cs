using System;


namespace Тумаков3
{
    class Program
    {
        enum BankAccount
        {
            Current = 100000,
            Savings = 300000
        }
        enum University
        {
            KGU,
            KAI,
            KHTI
        }
        struct Empolyee
        {
            public string name;
            public University uni;
            public void Print()
            {
                Console.WriteLine($"Имя - {name}, ВУЗ - {uni}\n");
            }
        }

        struct Bank_Account
        {
            public int Bank_Account_number;
            public string Bank_Account_type;
            public int Bank_Account_balance;
            public void Print()
            {
                Console.WriteLine("Номер счёта: {0}, тип счёта: {1}, баланс: {2} руб.\n", Bank_Account_number, Bank_Account_type, Bank_Account_balance);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            BankAccount type1 = BankAccount.Current;
            BankAccount type2 = BankAccount.Savings;
            Console.WriteLine("Тип счета - {0}, баланс - {1} руб.", type1, (int)type1);
            Console.WriteLine("Тип счета - {0}, баланс - {1} руб.\n", type2, (int)type2);


            Console.WriteLine("Упражнение 3.2");
            Bank_Account account = new Bank_Account();
            account.Bank_Account_number = 001;
            account.Bank_Account_type = "Savings";
            account.Bank_Account_balance = 1000000;
            account.Print();


            Console.WriteLine("Д/з 3.1");
            Empolyee employee = new Empolyee();
            employee.name = "Иван";
            employee.uni = 0;
            employee.Print();
        }
    }
}
