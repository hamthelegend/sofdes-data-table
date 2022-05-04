namespace SofdesDataTable
{
    public class Phone
    {

        public string Name { get; }
        public string OperatingSystem { get; }
        public string Soc { get; }
        public string RamSize { get; }

        public Phone(string name, string operatingSystem, string soc, int ramSize)
        {
            Name = name;
            OperatingSystem = operatingSystem;
            Soc = soc;
            RamSize = $"{ramSize} GB";
        }
    }
}
