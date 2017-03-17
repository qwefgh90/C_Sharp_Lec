using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount a = new BankAccount();
            a.Name = "홍길동";
            a.Print();

            BankAccount b = new BankAccount(1, "박찬호");
            b.Deposit(10000);
            if (b.Withdraw(50000))
                Console.WriteLine("잔액부족=>" + b.Name);
            b.Print();

            BankAccount c = new BankAccount(2, "이승엽", 10000);
            c.Deposit(10000);
            if(c.Withdraw(5000))
                Console.WriteLine("잔액부족=>" + c.Name);
            c.Print();

            BankAccount[] d = new BankAccount[3] { 
                new BankAccount(0,"",100)
                , new BankAccount(0,"",1500)
                , new BankAccount(0,"",1100) };

            Array.Sort(d);
            foreach(BankAccount i in d){
                Console.WriteLine("잔액 {0}", i);
            }

        }
    }
}
