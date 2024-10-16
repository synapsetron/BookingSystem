namespace BookingSystem.Model
{
    /// <summary>
    /// Represents a hotel in the booking system.
    /// </summary>
    public class Hotel
    {
        /// <summary>
        /// Gets or sets the hotel ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the hotel.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the location of the hotel.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the price per night for the hotel.
        /// </summary>
        public decimal PricePerNight { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hotel"/> class.
        /// </summary>
        /// <param name="id">The hotel ID.</param>
        /// <param name="name">The name of the hotel.</param>
        /// <param name="location">The location of the hotel.</param>
        /// <param name="pricePerNight">The price per night for the hotel.</param>
        public Hotel(int id, string name, string location, decimal pricePerNight)
        {
            Id = id;
            Name = name;
            Location = location;
            PricePerNight = pricePerNight;
        }

        /// <summary>
        /// Calculates the total price for a given number of nights.
        /// </summary>
        /// <param name="nights">The number of nights to stay.</param>
        /// <returns>The total price for the stay.</returns>
        public decimal CalculateTotalPrice(int nights)
        {
            return PricePerNight * nights;
        }

        /// <summary>
        /// Books the hotel for a given number of nights.
        /// </summary>
        /// <param name="nights">The number of nights to book.</param>
        public void Book(int nights)
        {
            // Code to book the hotel
        }

        /// <summary>
        /// Returns a string representation of the hotel.
        /// </summary>
        /// <returns>A string representing the hotel.</returns>
        public override string ToString()
        {
            return $"{Name} in {Location} costs {PricePerNight} per night";
        }
    }
}
