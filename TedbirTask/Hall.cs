using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TedbirTask
{
    internal class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int row;
        public int col;
        public bool[,] places = { };
        public List<Ticket> Tickets;
        public Hall(int id, string name, int row, int col)
        {
            Id = id;
            Name = name;
            this.row = row;
            this.col = col;
            places = new bool[row, col];
            Tickets = new List<Ticket>();
        }

        public void GetStatus()
        {
            for (int i = 0; i < places.GetLength(0); i++)
            {
                for (int j = 0; j < places.GetLength(1); j++)
                {
                    if (places[i, j] == true)
                    {
                        Console.Write($"{places[i, j]} ");
                    }
                    else
                    {
                        Console.Write($"{places[i, j]} ");
                    }
                }
                Console.WriteLine("");
            }
        }

        public void OrderTicket(int id, string name, string lastname, string tedbir, DateTime start, DateTime end, int row, int column)
        {


            if (places[row - 1, column - 1] == false)
            {
                Ticket ticket = new Ticket();
                ticket.Id = id;
                ticket.Name = name;
                ticket.Lastname = lastname;
                ticket.Tedbir = tedbir;
                ticket.Start = start;
                ticket.End = end;
                ticket.Row = row;
                ticket.Column = column;

                Console.WriteLine(@$"Bilet nomresi :{id} 
Ad,Soyad: {name} {lastname}
Tedbirin adi: {tedbir}
Baslama vaxti: {start.ToString("D HH:mm")}
Bitme vaxti: {end.ToString("D HH:mm")}
Sira ve sutun : {row} - {column}");
                places[row - 1, column - 1] = true;
            }
            else
            {
                Console.WriteLine("Bu yer artiq dolmushdur");
            }
        }
        public void UpdateTicket(int _id, int row,int column)
        {
            foreach (Ticket ticket in Tickets)
            {
                if (ticket.Id == _id)
                {
                ticket.Row = row;
                ticket.Column = column;
                }

            }
        }
    }
}
