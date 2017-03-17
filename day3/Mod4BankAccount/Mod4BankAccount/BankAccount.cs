using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4BankAccount
{
    /**
     * , , 
     */
    public class BankAccount : IDisposable, IComparable
    {
        private int accNo;//계좌번호
        private string name;//이름
        private long balance;//잔액
        private double interest;//이자율

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get;
            set;
        }

        //저금하다
        public void Deposit(long a)
        {
            balance = balance + a;
        }
        public bool Withdraw(long a)
        {
            if (a <= balance)
            {
                this.balance = this.balance - a;
                return true;
            }
            else
                return false;
        }
        //통장정리
        public void Print()
        {
            Console.WriteLine("No: {0} Name: {1} Balance: {2}", accNo, name, balance);
        }


        ~BankAccount()
        {

        }

        public BankAccount(int accNo = 0, string name = "", long balance = 0)
        {
            this.accNo = accNo;
            this.name = name;
            this.balance = balance;
        }

        public void Dispose()
        {
            //리소스 해제
        }

        public void Close()
        {
            Dispose();
        }

        public int CompareTo(object obj)
        {
            BankAccount right = obj as BankAccount;
            if (this.balance > right.balance)
                return 1;
            else if (this.balance == right.balance)
                return 0;
            else
                return -1;
        }

        public override string ToString()
        {
            return string.Format("Accname {0} Name {1} Balance{2}", accNo, name, balance);
        }
    }
}
