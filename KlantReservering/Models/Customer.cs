using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KlantReservering.Models
{
    public class Customer : BikeRentalModel
    {
        #region Attributes
        /* Attributes om de Properties voluit te schrijven en INotifyPropertyChanged te kunnen gebruiken 
         * Met regions kun je oninteressante code dichtklappen
         */
        private int _id;
        private string _name;
        private CustomerGender _gender;
        private double _height;
        private string _email;
        #endregion

        public int ID { get => _id; set { _id = value; Notify(); } }
        public string Name { get => _name; set { _name = value; Notify(); } }
        public CustomerGender Gender { get => _gender; set { _gender = value; Notify(); } }
        public double Height { get => _height; set { _height = value; Notify(); } }
        public string Email { get => _email; set { _email = value; Notify(); } }
    }

    public enum CustomerGender
    {
        Male,
        Female,
        Unknown
    }
}