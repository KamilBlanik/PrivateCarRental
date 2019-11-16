using PrivateCarRental.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PrivateCarRental.Models
{
    struct BookedDates
    {
        static int id;
        public int bookedDatesId { get; private set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }

        public BookedDates(DateTime start, DateTime end)
        {
            bookedDatesId = Interlocked.Increment(ref id);
            dateEnd = end;
            dateStart = start;
        }

    }
    public class Vehicle : IVehicle
    {
        private int _id { get; set; }
        private User _user { get; set; }
        private string _model { get; set; }
        private string _mileage { get; set; }
        private int _price { get; set; }
        private DateTime _avabilityFrom { get; set; }
        private DateTime _avabilityTo { get; set; }
        private List<BookedDates> _bookedDates { get; set; }
        private string _status { get; set; }
        private string _description { get; set; }
        private bool _isActive { get; set; }

        public Vehicle(int id, User user, string model, string mileage, int price, DateTime dateFrom, DateTime dateTo, string status, string description)
        {
            _id = id;
            _user = user;
            _model = model;
            _mileage = mileage;
            _price = price;
            _avabilityFrom = dateFrom;
            _avabilityTo = dateTo;
            _status = status;
            _description = description;
            _isActive = false;
            _bookedDates = new List<BookedDates>();
        }

        public void AddBookedDates(DateTime start, DateTime end)
        {
            BookedDates bookedDates = new BookedDates(start, end);
            _bookedDates.Add(bookedDates);
        }

        public bool IsAvalible(DateTime start, DateTime end)
        {
            bool avabilityCheck = ((start >= _avabilityFrom) && start <= _avabilityTo)
                && (end >= _avabilityFrom && end <= _avabilityTo);

            bool bookCheck = true;

            foreach (var item in _bookedDates)
            {
                if ((start >= item.dateStart && start <= item.dateEnd) || (end >= item.dateStart && end <= item.dateEnd))
                    bookCheck = false;
            }

            if (!_isActive || !avabilityCheck || !bookCheck)
                return false;
            return true;
        }

        public void SwitchActivity()
        {
            _isActive = !_isActive; 
        }

        public bool Equal(Vehicle vehicle)
        {
            return vehicle._id==_id;
        }

    }
}
