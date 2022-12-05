using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Student: Person
    {
       private string card_number;
        public string CardNumber { get { return card_number; } set { card_number = value; } } /*Encapsulation*/
       public string Groupname { get; set; }



        public Student(string name, string lastname,string groupname, string cardNumber) : base(name, lastname) /*Inheritance*/
        {
            this.Groupname = groupname;
            CardNumber = cardNumber;
        }



        //public string setCardNumber(string card)
        //{
        //    return card_number=card;
        //}
        //public string getCardNumber() //Encapsulation
        //{
        //    return card_number;
        //}



        public override string getfullname() /*Polymorphism*/
        {
            return $"{Name} {Lastname} {Groupname} {card_number}";
        }
    }
}
