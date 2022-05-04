using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofdesDataTable
{

    public class PhoneManufacturer
    {
        public string Name { get; }
        public string Origin { get; }
        public string MarketShare { get; }
        public string ParentCompany { get; }
        public string StockSymbol { get; }
        public Phone[] Phones { get; }

        public PhoneManufacturer(
            string name, 
            string origin, 
            double marketShare, 
            string parentCompany, 
            string stockSymbol,
            Phone[] phones
            )
        {
            Name = name;
            Origin = origin;
            MarketShare = $"{marketShare}%";
            ParentCompany = parentCompany;
            StockSymbol = stockSymbol;
            Phones = phones;
        }

    }

}
