using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace KlantReservering.Models
{
    public class Store : BikeRentalModel
    {
        #region Attributes
        /* Attributes om de Properties voluit te schrijven en INotifyPropertyChanged te kunnen gebruiken 
         * Met regions kun je oninteressante code dichtklappen
         */
        private int _id;
        private int _maxCapacity;
        private string _name;
        #endregion

        public int ID { get => _id; set { _id = value; Notify(); } } // INotifyPropertyChanged hier zodat gelijk alle schermen geupdate worden als je een store wijzigt / verwijdert
        public string Name { get => _name; set { _name = value; Notify(); } } // Notify als we Name aanpassen (zodat ook de titelbalk meegaat)
        public string Address { get; set; }
        public string City { get; set; }
        public ObservableCollection<Bike> Bikes { get; set; }
        public int MaxCapacity { get => _maxCapacity; set { _maxCapacity = value; Notify() /* Notify voor zichzelf */; Notify("SpaceLeft"); /* Notify voor SpaceLeft */ } } // Als je MaxCapacity aanpast moet SpaceLeft ook opnieuw ververst worden op het scherm
        public int SpaceLeft { get => MaxCapacity - Bikes.Count; } // SpaceLeft telt hoeveel plekken deze winkel nog heeft voor nieuwe fietsen

        public Store()
        {
            Bikes = new ObservableCollection<Bike>(); // Bij het aanmaken van een nieuwe Store starten we gelijk met een nieuwe lege lijst Bikes
        }
    }
}