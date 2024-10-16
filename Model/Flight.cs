namespace BookingSystem.Model
{
    /// <summary>
    /// Represents a flight in the booking system.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Gets or sets the flight number.
        /// </summary>
        public string FlightNumber { get; set; }

        /// <summary>
        /// Gets or sets the price of the flight.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flight"/> class.
        /// </summary>
        /// <param name="flightNumber">The flight number.</param>
        /// <param name="price">The price of the flight.</param>
        public Flight(string flightNumber, decimal price)
        {
            FlightNumber = flightNumber;
            Price = price;
        }

        /// <summary>
        /// Books the flight.
        /// </summary>
        /// <returns>True if booking is successful; otherwise, false.</returns>
        public bool Book()
        {
            // Logic for booking the flight
            return true; // Success
        }
    }
}
