using PrivateCarRental.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateCarRental.Models
{
    public class User : IUser
    {
        protected int _id { get; set; }
        [StringLength(20, MinimumLength = 6)]
        protected string _login { get; set; }
        [StringLength(20, MinimumLength = 6)]
        protected string _password { get; set; }
        protected string _email { get; set; }
        protected string _name { get; set; }
        protected string _surname { get; set; }
        [StringLength(9, MinimumLength = 9)]
        protected string _identityCardNr { get; set; }
        protected string _permission { get; set; }

        public User(int id, string login, string password, string email, string name, string surname, string identityCardNr, string permission)
        {
            _id = id;
            _login = login;
            _password = password;
            _email = email;
            _name = name;
            _surname = surname;
            _identityCardNr = identityCardNr;
            _permission = permission;
        }

        public void DeleteVehicle(Vehicle vehicle)
        {

        }

        public void SwitchActivity(Vehicle vehicle)
        {
            vehicle.SwitchActivity();
        }

        public bool Equal(User user)
        {
            return user._id==_id;
        }

        public override bool Equals(object obj)
        {
            var user = obj as User;
            return user != null &&
                   _id == user._id &&
                   _login == user._login &&
                   _password == user._password &&
                   _email == user._email &&
                   _name == user._name &&
                   _surname == user._surname &&
                   _identityCardNr == user._identityCardNr &&
                   _permission == user._permission;
        }
    }
}
