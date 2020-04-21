using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace KlantReservering.Models
{
    public class BikeRentalModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /* Een iets andere versie dan we in het college hebben gemaakt:
         * deze versie gebruikt [CallerMemberName] om zelf alvast de propertyname in te vullen, zodat
         * we gewoon Notify() kunnen gebruiken ipv Notify("Address") ofzo.
         * We kunnen die default nog steeds overrulen, bijvoorbeeld bij MaxCapacity waar we expliciet
         * ook SpaceLeft willen Notify-en
         * https://docs.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.callermembernameattribute?view=netframework-4.8
         */
        public void Notify([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}