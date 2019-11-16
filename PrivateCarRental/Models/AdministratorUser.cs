using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateCarRental.Models
{
    public class AdministratorUser : User
    {
        private List<CommonUser> _bannedUsers { get; set; }
        private List<CommonUser> _unbannedUsers { get; set; }

        public AdministratorUser(int id, string login, string password, string email, string name, string surname, string identityCardNr, string permission)
            : base(id, login, password, email, name, surname, identityCardNr, permission)
        {
            _bannedUsers = new List<CommonUser>();
        }

        public void BanUser(CommonUser user)
        {
            if (user.BanUser())
                _bannedUsers.Add(user);
        }

        public void UnbanUser(CommonUser user)
        {
            if (user.UnbanUser())
            {
                _unbannedUsers.Add(user);
            }
        }
    }
}
