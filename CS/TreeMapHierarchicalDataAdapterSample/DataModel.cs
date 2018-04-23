using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeMapHierarchicalDataAdapterSample {
    public class Country {
        public string Name { get; set; }
        public double Gdp { get; set; }
    }

    public class SideOfWorld {
        public string Name { get; set; }

        List<Country> countries = new List<Country>();
        public List<Country> Countries { get { return countries; } }
    }
}
