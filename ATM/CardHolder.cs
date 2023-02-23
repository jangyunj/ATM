using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class CardHolder
    {
        public string CardNum { get; set; }
        public int PIN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }

        public void cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            CardNum = cardNum;
            PIN = pin;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }


        public String getNum()
        {
            return CardNum;
        }
        public int getPIN()
        {
            return PIN;
        }
        public string getFirstName()
        {
            return FirstName;
        }
        public string getLastName()
        {
            return LastName;
        }
        public double getBalance()
        {
            return Balance;
        }
        public void setNum(string newCardNum)
        {
            CardNum = newCardNum;
        }
        public void setPIN(int newPIN)
        {
            PIN = newPIN;
        }
        public void setFirstName(string newFirstName)
        {
            FirstName = newFirstName;
        }
        public void setLastName(string newLastName)
        {
            LastName = newLastName;
        }
        public void setBalance(double newBalance)
        {
            Balance = newBalance;
        }

    }
}