using PublisherLib.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLib
{
   public class Account
    {
        private  int _accountNo;
        private  String _name;
        private double _balance;
        private int _mobile;
        private string _email;
       private List<INotifier> notifiers=new List<INotifier>();
        public Account(int ano, string n, double bal,string email)
        {
            this._accountNo = ano;
            this._name = n;
            this._balance = bal;
            this._email = email;
        }
        public int GetAccNo()
        {
            return _accountNo;
        }
        public String GetName()
        {
            return _name;
        }
        public double GetBalance()
        {
            return _balance;
        }
        public string Email
        {
            get
            {
                return _email;
            }
        }
        public void Deposit(double amount)
        {
            _balance += amount;
            NotifySubscriber();
        }

        private void NotifySubscriber()
        {
            foreach(var notifier in notifiers)
            {
                notifier.Notify(this);
            }
        }

        public void Withdrow(double amount)
        {
            double currentAmount = _balance;
            currentAmount -= amount;
            if(currentAmount<500)
            {
                Console.WriteLine("Withdrow fail");
            }
            else
            {
                _balance -= amount;
                NotifySubscriber();
            }



        }
        public void AddNotifier(INotifier notifier)
        {
            notifiers.Add(notifier);
        }

       
    }
}
