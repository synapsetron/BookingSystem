namespace BookingSystem.Model
{
    /// <summary>
    /// Represents a taxi service in the booking system.
    /// </summary>
    public class Taxi
    {
        /// <summary>
        /// Gets or sets the name of the taxi company.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the price per kilometer for the taxi service.
        /// </summary>
        public decimal PricePerKm { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Taxi"/> class.
        /// </summary>
        /// <param name="companyName">The name of the taxi company.</param>
        /// <param name="pricePerKm">The price per kilometer.</param>
        public Taxi(string companyName, decimal pricePerKm)
        {
            CompanyName = companyName;
            PricePerKm = pricePerKm;
        }

        /// <summary>
        /// Calculates the fare for a given distance.
        /// </summary>
        /// <param name="distance">The distance traveled in kilometers.</param>
        /// <returns>The total fare for the trip.</returns>
        public decimal CalculateFare(decimal distance)
        {
            return distance * PricePerKm;
        }
    }
}
