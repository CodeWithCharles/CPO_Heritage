using CPO_Abstract_Perso.Classes;
using System;

namespace CPO_Abstract_Perso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankAccount bankAccount = new BankAccount("Bonsoir", 0);
            CheckingAccount checkingAccount = new CheckingAccount("Checking", 100.5, -300);
            SavingsAccount savingsAccount = new SavingsAccount("Savings", 200.0, 2.5);

            Console.WriteLine("Testing CheckingAccount withdrawal, inherited from abstract class : \n");
            Console.WriteLine("Withdraw 100 : " + checkingAccount.withdrawal(100) + "\nNew Balance : " + checkingAccount.getBalance());
            Console.WriteLine("Withdraw 200 : " + checkingAccount.withdrawal(200) + "\nNew Balance : " + checkingAccount.getBalance());
            Console.WriteLine("Withdraw 300 : " + checkingAccount.withdrawal(300) + "\nNew Balance : " + checkingAccount.getBalance());

            Console.WriteLine("Testing SavingsAccount withdrawal, inherited from abstract class : \n");
            Console.WriteLine("Withdraw 100 : " + savingsAccount.withdrawal(100) + "\nNew Balance : " + savingsAccount.getBalance());
            Console.WriteLine("Withdraw 200 : " + savingsAccount.withdrawal(200) + "\nNew Balance : " + savingsAccount.getBalance());
        }
    }
}
