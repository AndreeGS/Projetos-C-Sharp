using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiriza_BackEnd.Model
{
    internal class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Valor> Valors { get; set; }

        public TravelModel? Travels { get; set; }

        public CardModel Cards { get; set; }

        public UserModel(int id, string name, string email, string password) 
        { 
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }
        public UserModel(int id, string name, string email, string password, TravelModel? travels)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Travels = travels;
        }
        public UserModel(int id, string name, string email, string password, CardModel? cards)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Cards = cards;
        }

        public override string ToString()
        {


            return "Usuario: " +
                Name
                + "\n ID do Usuario: "
                + Id
                + "\n Email do Usuario: "
                + Email
                + "\n Password: "
                + Password
                + "\nViagens: "
                + Travels
                + "\nCards: "
                + Cards;
                             
        }
    }
}
