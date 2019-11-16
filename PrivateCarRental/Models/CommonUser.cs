using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateCarRental.Models
{
    public class CommonUser : User
    {

        private List<Reservation> _reservationHistiory { get; set; }
        private bool _isBanned { get; set; }

        public CommonUser(int id, string login, string password, string email, string name, string surname, string identityCardNr, string permission) 
            : base(id, login, password, email, name, surname, identityCardNr, permission)
        {
            _reservationHistiory = new List<Reservation>();
            _isBanned = false;
        }

        public void AddNewVehicle(int id, string model, string mileage, int price, DateTime dateFrom, DateTime dateTo, string status, string description)
        {
            Vehicle vehicle = new Vehicle(id, this, model, mileage, price, dateFrom, dateTo, status, description);
            //TODO 
        }

        public bool BookVehicle(Vehicle vehicle, DateTime start, DateTime end)
        {
            try
            {
                if(vehicle.IsAvalible(start, end))
                {
                    vehicle.AddBookedDates(start, end);
                    //TODO
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool BanUser()
        {
            if (_isBanned)
                return false;
            else
            {
                _isBanned = true;
                return true;
            }
        }

        public bool UnbanUser()
        {
            if (_isBanned)
            {
                _isBanned = false;
                return true;

            }
            else
                return false;
        }

        public bool RentVehicle(Vehicle vehicle)
        {
            return true;
        }

        public void CancelReservation(int reservationId)
        {

        }

    }
}
