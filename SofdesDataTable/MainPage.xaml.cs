using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Controls;

namespace SofdesDataTable
{

    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        static readonly Phone[] samsungPhones =
        {
            new Phone("Galaxy S22", "Android", "Exynos 2200", 8),
            new Phone("Galaxy Fold 3", "Android", "Snapdragon 888 5G", 12)
        };

        static readonly Phone[] applePhones =
        {
            new Phone("iPhone 13 Pro Max", "iOS", "A15 Bionic", 6),
            new Phone("iPhone 13 Mini", "iOS", "A15 Bionic", 4)
        };

        public PhoneManufacturer[] Manufacturers =
        {
            new PhoneManufacturer("Samsung", "South Korea", 27.94, "None", "SSNLF", samsungPhones),
            new PhoneManufacturer("Apple", "US", 27.68, "None", "AAPL", applePhones)
        };
        bool manufacturerSelected = false;
        public bool ManufacturerSelected
        {
            get { return manufacturerSelected; }
            set { 
                manufacturerSelected = value;
                OnPropertyChanged();
            }
        }
        PhoneManufacturer selectedManufacturer = null;
        public PhoneManufacturer SelectedManufacturer { 
            get { return selectedManufacturer; } 
            set {
                selectedManufacturer = value;
                OnPropertyChanged();
            } 
        }

        int selectedManufacturerIndex = -1;
        public int SelectedManufacturerIndex
        {
            get { return selectedManufacturerIndex; }
            set {
                ManufacturerSelected = value >= 0;
                if (ManufacturerSelected)
                {
                    SelectedManufacturer = Manufacturers[value];
                } else
                {
                    SelectedManufacturer = null;
                }
                selectedManufacturerIndex = value;
            }
        }

        bool phoneSelected = false;
        public bool PhoneSelected
        {
            get { return phoneSelected; }
            set { 
                phoneSelected = value;
                OnPropertyChanged();
            }
        }
        Phone selectedPhone = null;
        public Phone SelectedPhone { 
            get { return selectedPhone; } 
            set {
                selectedPhone = value;
                OnPropertyChanged();
            } 
        }

        int selectedPhoneIndex = -1;
        public int SelectedPhoneIndex
        {
            get { return selectedPhoneIndex; }
            set {
                PhoneSelected = value >= 0;
                if (PhoneSelected)
                {
                    SelectedPhone = SelectedManufacturer.Phones[value];
                }
                else
                {
                    SelectedPhone = null;
                }
                selectedPhoneIndex = value;
            }
        }


        public MainPage()
        {
            this.InitializeComponent();
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
