using System.Collections.Generic;
using System.Windows;

namespace TreeMapHierarchicalDataAdapterSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            DataContext = PopulateData();
        }

        List<SideOfWorld> PopulateData() {
            List<SideOfWorld> worldSides = new List<SideOfWorld>();

            SideOfWorld americas = new SideOfWorld { Name = "Americas" };
            worldSides.Add(americas);
            americas.Countries.Add(new Country { Name = "United States", Gdp = 11.384 });
            americas.Countries.Add(new Country { Name = "United Brazil", Gdp = 1.799 });
            americas.Countries.Add(new Country { Name = "United States", Gdp = 1.572 });

            SideOfWorld europe = new SideOfWorld { Name = "Europe" };
            worldSides.Add(europe);
            europe.Countries.Add(new Country { Name = "Germany", Gdp = 3.371 });
            europe.Countries.Add(new Country { Name = "United Kingdom", Gdp = 2.582 });
            europe.Countries.Add(new Country { Name = "France", Gdp = 2.422 });
            europe.Countries.Add(new Country { Name = "Italy", Gdp = 1.809 });

            SideOfWorld asia = new SideOfWorld { Name = "Asia" };
            worldSides.Add(asia);
            asia.Countries.Add(new Country { Name = "China", Gdp = 17.968 });
            asia.Countries.Add(new Country { Name = "Japan", Gdp = 4.116 });
            asia.Countries.Add(new Country { Name = "India", Gdp = 2.864 });

            return worldSides;
        }
    }
}