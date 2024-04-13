namespace _03_Enum
{
    enum DayOfWeek
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    enum TransportType
    {
        Semitrailer, Coupling, Refrigerator, OpenSideTruck, Tank, FuelTruck
    }
    enum Discount
    {
        Default, Incentive = 2, Patron = 5, VIP = 15
    }
    enum CommodityType // product type
    {
        FrozenFood = 1, Food, DomesticChemistry,
        BuildingMaterials, Petrol
    }


    internal class Program
    {
        public static DayOfWeek NextDay(DayOfWeek day)
        {
            return (day < DayOfWeek.Sunday) ? ++day : DayOfWeek.Monday;
        }
        static void Main(string[] args)
        {
            DayOfWeek day = DayOfWeek.Sunday;
            Console.WriteLine($"Next day (name) : {day.ToString()}");
            Console.WriteLine($"Next day (value) : {(int)day}");

            string[] names = Enum.GetNames(typeof(DayOfWeek));

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Discount[] values = (Discount[])Enum.GetValues(typeof(Discount));
            foreach (var item in values) Console.WriteLine($"{item} - {(int)item}");
        }
    }
}
