using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateCarRental.Models
{
    public class Reservation
    {

        private static int _lastId { get; set; }
        private int _id { get; set; }
        private Vehicle _vehicle { get; set; }
        private CommonUser _commonUser { get; set; }
        private DateTime _dateStart { get; set; }
        private DateTime _dateEnd { get; set; }
        private string _status { get; set; }
        private string _mileageStart { get; set; }
        private string _mileageEnd { get; set; }
        private string _comment { get; set; }

        public Reservation(int id, Vehicle vehicle, CommonUser commonUser, DateTime dateStart, DateTime dateEnd, string status, string mileageStart, string mileageEnd, string comment)
        {
            _id = id;
            _vehicle = vehicle;
            _commonUser = commonUser;
            _dateStart = dateStart;
            _dateEnd = dateEnd;
            _status = status;
            _mileageStart = mileageStart;
            _mileageEnd = mileageEnd;
            _comment = comment;
        }

        public Reservation(Vehicle vehicle, CommonUser commonUser, DateTime dateStart, DateTime dateEnd, string status, string mileageStart, string mileageEnd, string comment)
        {
            _id = _lastId + 1;
            _vehicle = vehicle;
            _commonUser = commonUser;
            _dateStart = dateStart;
            _dateEnd = dateEnd;
            _status = status;
            _mileageStart = mileageStart;
            _mileageEnd = mileageEnd;
            _comment = comment;

            _lastId = _lastId + 1;
        }


    }
}
