namespace BookingSystem.Model
{
    namespace BookingSystem.Model
    {
        public class AdministratorRefactored
        {
            public string Name { get; private set; }
            private string _adminPassword { get; set; }
            private List<Hotel> _hotels;

            public AdministratorRefactored(string name = "admin", string adminPassword = "admin")
            {
                Name = name;
                _adminPassword = adminPassword;
                _hotels = new List<Hotel>();
            }

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
            public int GetHotelsCount() => _hotels.Count;

            private bool IsValidAdmin(string name, string password)
            {
                return Name == name && _adminPassword == password;
            }

            public void AddHotel(Hotel hotel) => ExecuteHotelAction(hotel, "added", _hotels.Add);

            public void RemoveHotel(Hotel hotel) 
            {
                _hotels.Remove(hotel);
                Console.WriteLine($"Hotel '{hotel.Name}' removed successfully.");
            }

            public void UpdateHotel(Hotel hotel, string newName)
            {
                hotel.Name = newName;
                Console.WriteLine($"Hotel '{hotel.Name}' updated successfully.");
            }

            public void AddFlight(Flight flight) => ExecuteFlightAction(flight, "added");

            public void RemoveFlight(Flight flight) => ExecuteFlightAction(flight, "removed");

            public void UpdateFlight(Flight flight) => ExecuteFlightAction(flight, "updated");

            public void AddTaxi(Taxi taxi) => ExecuteTaxiAction(taxi, "added");

            public void RemoveTaxi(Taxi taxi) => ExecuteTaxiAction(taxi, "removed");

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

}
