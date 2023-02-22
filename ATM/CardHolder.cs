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