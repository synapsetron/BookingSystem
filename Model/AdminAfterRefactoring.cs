namespace BookingSystem.Model
{
    /// <summary>
    /// Represents an administrator in the booking system.
    /// </summary>
    public class AdministratorRefactored
    {
        /// <summary>
        /// Gets the name of the administrator.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Private field storing the administrator's password.
        /// </summary>
        private string _adminPassword;

        /// <summary>
        /// List of hotels managed by the administrator.
        /// </summary>
        private List<Hotel> _hotels;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministratorRefactored"/> class.
        /// </summary>
        /// <param name="name">The name of the administrator. Default is "admin".</param>
        /// <param name="adminPassword">The administrator's password. Default is "admin".</param>
        public AdministratorRefactored(string name = "admin", string adminPassword = "admin")
        {
            Name = name;
            _adminPassword = adminPassword;
            _hotels = new List<Hotel>();
        }

        /// <summary>
        /// Logs in the administrator with the given name and password.
        /// </summary>
        /// <param name="name">The name of the administrator.</param>
        /// <param name="password">The password of the administrator.</param>
        /// <returns>True if login is successful; otherwise, false.</returns>
        public bool Login(string name, string password)
        {
            if (IsValidAdmin(name, password))
            {
                Console.WriteLine("Welcome Admin");
                return true;
            }

            Console.WriteLine("Invalid Admin");
            return false;
        }

        /// <summary>
        /// Gets the count of hotels managed by the administrator.
        /// </summary>
        /// <returns>The number of hotels.</returns>
        public int GetHotelsCount() => _hotels.Count;

        /// <summary>
        /// Checks if the provided name and password match the administrator's credentials.
        /// </summary>
        /// <param name="name">The name of the administrator.</param>
        /// <param name="password">The password of the administrator.</param>
        /// <returns>True if valid; otherwise, false.</returns>
        private bool IsValidAdmin(string name, string password)
        {
            return Name == name && _adminPassword == password;
        }

        /// <summary>
        /// Adds a hotel to the administrator's list.
        /// </summary>
        /// <param name="hotel">The hotel to be added.</param>
        public void AddHotel(Hotel hotel) => ExecuteHotelAction(hotel, "added", _hotels.Add);

        /// <summary>
        /// Removes a hotel from the administrator's list.
        /// </summary>
        /// <param name="hotel">The hotel to be removed.</param>
        public void RemoveHotel(Hotel hotel)
        {
            _hotels.Remove(hotel);
            Console.WriteLine($"Hotel '{hotel.Name}' removed successfully.");
        }

        /// <summary>
        /// Updates the name of an existing hotel.
        /// </summary>
        /// <param name="hotel">The hotel to be updated.</param>
        /// <param name="newName">The new name for the hotel.</param>
        public void UpdateHotel(Hotel hotel, string newName)
        {
            hotel.Name = newName;
            Console.WriteLine($"Hotel '{hotel.Name}' updated successfully.");
        }

        /// <summary>
        /// Adds a flight (functionality to be implemented).
        /// </summary>
        /// <param name="flight">The flight to be added.</param>
        public void AddFlight(Flight flight) => ExecuteFlightAction(flight, "added");

        /// <summary>
        /// Removes a flight (functionality to be implemented).
        /// </summary>
        /// <param name="flight">The flight to be removed.</param>
        public void RemoveFlight(Flight flight) => ExecuteFlightAction(flight, "removed");

        /// <summary>
        /// Updates a flight (functionality to be implemented).
        /// </summary>
        /// <param name="flight">The flight to be updated.</param>
        public void UpdateFlight(Flight flight) => ExecuteFlightAction(flight, "updated");

        /// <summary>
        /// Adds a taxi service (functionality to be implemented).
        /// </summary>
        /// <param name="taxi">The taxi service to be added.</param>
        public void AddTaxi(Taxi taxi) => ExecuteTaxiAction(taxi, "added");

        /// <summary>
        /// Removes a taxi service (functionality to be implemented).
        /// </summary>
        /// <param name="taxi">The taxi service to be removed.</param>
        public void RemoveTaxi(Taxi taxi) => ExecuteTaxiAction(taxi, "removed");

        /// <summary>
        /// Updates a taxi service (functionality to be implemented).
        /// </summary>
        /// <param name="taxi">The taxi service to be updated.</param>
        public void UpdateTaxi(Taxi taxi) => ExecuteTaxiAction(taxi, "updated");

        private void ExecuteHotelAction(Hotel hotel, string action, Action<Hotel> hotelAction)
        {
            hotelAction(hotel);
            Console.WriteLine($"Hotel '{hotel.Name}' {action} successfully.");
        }

        private void ExecuteFlightAction(Flight flight, string action)
        {
            Console.WriteLine($"Flight '{flight.FlightNumber}' {action} successfully.");
        }

        private void ExecuteTaxiAction(Taxi taxi, string action)
        {
            Console.WriteLine($"Taxi service '{taxi.CompanyName}' {action} successfully.");
        }
    }
}
