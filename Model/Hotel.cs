namespace BookingSystem.Model
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public decimal PricePerNight { get; set; }

        public Hotel(int id, string name, string location, decimal pricePerNight)
        {
            Id = id;
            Name = name;
            Location = location;
            PricePerNight = pricePerNight;
        }

        public decimal CalculateTotalPrice(int nights)
        {
            return PricePerNight * nights;
        }

        public void Book(int nights)
        {
            // Code to book the hotel
        }
        public override string ToString()
        {
            return $"{Name} in {Location} costs {PricePerNight} per night";
        }
    }
}
