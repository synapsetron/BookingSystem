namespace BookingSystem.Model
{
    public class Taxi
    {
        public string CompanyName { get; set; }
        public decimal PricePerKm { get; set; }

        public Taxi(string companyName, decimal pricePerKm)
        {
            CompanyName = companyName;
            PricePerKm = pricePerKm;
        }

        public decimal CalculateFare(decimal distance)
        {
            return distance * PricePerKm;
        }
    }
}
