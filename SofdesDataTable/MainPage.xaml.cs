using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Controls;

namespace SofdesDataTable
{
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public readonly PhoneManufacturer[] Manufacturers =
        {
            new PhoneManufacturer(
                "Samsung",
                "South Korea",
                27.94,
                "None",
                "Not traded publicly",
                new[]
                {
                    new Phone("Galaxy Z Fold3 5G", "Android 11", "Snapdragon 888 5G", 12),
                    new Phone("Galaxy S22 Ultra 5G", "Android 12", "Exynos 2200", 12),
                    new Phone("Galaxy S22+ 5G", "Android 12", "Exynos 2200", 8),
                    new Phone("Galaxy S22 5G", "Android 12", "Exynos 2200", 8)
                }
            ),
            new PhoneManufacturer(
                "Apple",
                "US",
                27.68,
                "None",
                "NASDAQ: AAPL",
                new[]
                {
                    new Phone("iPhone 13 Pro Max", "iOS 15", "A15 Bionic", 6),
                    new Phone("iPhone 13 Pro", "iOS 15", "A15 Bionic", 6),
                    new Phone("iPhone 13", "iOS 15", "A15 Bionic", 4),
                    new Phone("iPhone 13 Mini", "iOS 15", "A15 Bionic", 4)
                }
            ),
            new PhoneManufacturer(
                "Xiaomi",
                "China",
                12.18,
                "None",
                "SEHK: 1810",
                new[]
                {
                    new Phone("12 Pro", "Android 12", "Snapdragon 8 Gen 1", 12),
                    new Phone("12", "Android 12", "Snapdragon 8 Gen 1", 12),
                    new Phone("Poco F4 GT", "Android 12", "Snapdragon 8 Gen 1", 12),
                    new Phone("Poco M4 5G", "Android 12", "Dimensity 700", 6)
                }
            ),
            new PhoneManufacturer(
                "Huawei",
                "China",
                6.18,
                "Huawei Investment & Holding",
                "Not traded publicly",
                new[]
                {
                    new Phone("Mate Xs 2", "HarmonyOS 2.0", "Snapdragon 888 4G", 12),
                    new Phone("nova 9 SE 5G", "Android 11", "Snapdragon 695 5G", 8),
                    new Phone("nova 9 SE", "Android 11", "Snapdragon 680 4G", 8),
                    new Phone("nova Y70 Plus", "Android 11", "Unspecified", 4)
                }
            ),
            new PhoneManufacturer(
                "OPPO",
                "China",
                5.37,
                "BBK Electronics",
                "Not traded publicly",
                new[]
                {
                    new Phone("K10 Pro", "Android 12", "Snapdragon 888 5G", 12),
                    new Phone("K10 5G", "Android 12", "Dimensity 8000 Max", 12),
                    new Phone("F21 Pro 5G", "Android 12", "Snapdragon 695 5G", 8),
                    new Phone("F21 Pro", "Android 12", "Snapdragon 680 4G", 8),
                    new Phone("Reno7", "Android 12", "Snapdragon 680 4G", 8)
                }
            )
        };

        private PhoneManufacturer _selectedManufacturer;

        public PhoneManufacturer SelectedManufacturer
        {
            get => _selectedManufacturer;
            set
            {
                if (value != _selectedManufacturer)
                {
                    _selectedManufacturer = value;
                    OnPropertyChanged();
                }
            }
        }

        private Phone _selectedPhone;

        public Phone SelectedPhone
        {
            get => _selectedPhone;
            set
            {
                if (value != _selectedPhone)
                {
                    _selectedPhone = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}