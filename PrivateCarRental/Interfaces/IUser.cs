using PrivateCarRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateCarRental.Interfaces
{
    interface IUser
    {
        void DeleteVehicle(Vehicle vehicle);
        void SwitchActivity(Vehicle vehicle);
        bool Equal(User user);
    }
}
