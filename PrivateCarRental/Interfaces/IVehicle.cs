using PrivateCarRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateCarRental.Interfaces
{
    interface IVehicle
    {
        void SwitchActivity();
        bool Equal(Vehicle vehicle);
        bool IsAvalible(DateTime start, DateTime end);
    }
}
