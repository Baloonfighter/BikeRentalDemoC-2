using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace KlantReservering.Models
{
    public class Reservation : BikeRentalModel
    {
        #region Attributes
        /* Attributes om de Properties voluit te schrijven en INotifyPropertyChanged te kunnen gebruiken 
         * Met regions kun je oninteressante code dichtklappen
         */
        private int _id;
        private Customer _customer;
        private ObservableCollection<Bike> _bikes;
        private DateTime _startDate;
        private DateTime _endDate;
        private Store _pickupStore;
        private Store _dropoffStore;
        private double _totalPrice;
        #endregion

        // INotifyPropertyChanged hier zodat gelijk alle schermen geupdate worden als je een store wijzigt / verwijdert
        public int ID { get => _id; set { _id = value; Notify(); } }
        public Customer Customer { get => _customer; set { _customer = value; Notify(); } }
        public ObservableCollection<Bike> Bikes { get => _bikes; set { _bikes = value; Notify(); } }
        public DateTime StartDate { get => _startDate; set { _startDate = value; Notify(); } }
        public DateTime EndDate { get => _endDate; set { _endDate = value; Notify(); } }
        public Store PickupStore { get => _pickupStore; set { _pickupStore = value; Notify(); } }
        public Store DropoffStore { get => _dropoffStore; set { _dropoffStore = value; Notify(); } }
        public double TotalPrice { get => _totalPrice; set { _totalPrice = value; Notify(); } }
    }
}