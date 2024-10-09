namespace BookingSystem.Model
{
    public class Flight
    {
        public string FlightNumber { get; set; }
        public decimal Price { get; set; }

        public Flight(string flightNumber, decimal price)
        {
            FlightNumber = flightNumber;
            Price = price;
        }

        public bool Book()
        {
            // Логика бронирования авиабилета
            return true; // Успех
        }
    }
}
