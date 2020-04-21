using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KlantReservering.Models
{
    public class Bike : BikeRentalModel
    {
        #region Attributes
        /* Attributes om de Properties voluit te schrijven en INotifyPropertyChanged te kunnen gebruiken 
         * Met regions kun je oninteressante code dichtklappen
         */
        private int _id;
        private double _hourRate;
        private double _dailyRate;
        private Store _inStore;
        private int _size;
        private string _brand;
        private BikeType _type;
        private BikeGender _gender;
        private bool _rented;
        #endregion

        public int ID { get => _id; set { _id = value; Notify(); } } // INotifyPropertyChanged hier zodat gelijk alle schermen geupdate worden als je een store wijzigt / verwijdert
        public double HourRate { get => _hourRate; set { _hourRate = value; Notify(); } } // INotifyPropertyChanged hier zodat gelijk alle schermen geupdate worden als je een store wijzigt / verwijdert
        public double DailyRate { get => _dailyRate; set { _dailyRate = value; Notify(); } } // INotifyPropertyChanged hier zodat gelijk alle schermen geupdate worden als je een store wijzigt / verwijdert
        public int Size { get => _size; set { _size = value; Notify(); } } // INotifyPropertyChanged hier zodat gelijk alle schermen geupdate worden als je de size wijzigt
        public string Brand { get => _brand; set { _brand = value; Notify(); } } // INotifyPropertyChanged hier zodat gelijk alle schermen geupdate worden als je de brand wijzigt 
        public BikeType Type { get => _type; set { _type = value; Notify(); } } // INotifyPropertyChanged hier zodat gelijk alle schermen geupdate worden als je de type wijzigt 
        public BikeGender Gender { get => _gender; set { _gender = value; Notify(); } } // INotifyPropertyChanged hier zodat gelijk alle schermen geupdate worden als je de gender wijzigt
        public bool Rented { get => _rented; set { _rented = value; Notify(); } } // INotifyPropertyChanged hier zodat gelijk alle schermen geupdate worden als je wijzigt of ie uitgeleend is
        public Store InStore { get => _inStore; set { _inStore = value; Notify(); } } // INotifyPropertyChanged hier zodat gelijk alle schermen geupdate worden als je een store wijzigt / verwijdert
    }

    public enum BikeType
    {
        CityBike,
        MountainBike,
        Hybrid
    }

    public enum BikeGender
    {
        HerenFiets,
        DamesFiets
    }
}