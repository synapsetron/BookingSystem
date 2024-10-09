namespace BookingSystem.Model
{
    public class Administrator
    {
        public string Name { get; set; }
        private string _adminPassword { get; set; }
        public List<Hotel> _hotels { get; set; }
        public Administrator()
        {
            Name = "admin";
            _adminPassword = "admin";
            _hotels = new List<Hotel>();
        }
        public Administrator(string name, string adminPassword)
        {
            this.Name = name;
            this._adminPassword = adminPassword;
            _hotels = new List<Hotel>();
        }
        public bool loginAdmin(string name , string password)
        {
            if (this.Name == name && this._adminPassword == password)
            {
                Console.WriteLine("Welcome Admin");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Admin");
            }
            return false;
        }

        public void AddHotel(Hotel hotel)
        {
            _hotels.Add(hotel);
            Console.WriteLine($"Hotel '{hotel.Name}' added successfully.");
        }

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

        public void AddFlight(Flight flight)
        {
            
            Console.WriteLine($"Flight '{flight.FlightNumber}' added successfully.");
        }

        public void RemoveFlight(Flight flight)
        {
      
            Console.WriteLine($"Flight '{flight.FlightNumber}' removed successfully.");
        }

        public void UpdateFlight(Flight flight)
        {
          
            Console.WriteLine($"Flight '{flight.FlightNumber}' updated successfully.");
        }

        public void AddTaxi(Taxi taxi)
        {
            // Логіка для додавання таксі
            Console.WriteLine($"Taxi service '{taxi.CompanyName}' added successfully.");
        }

        public void RemoveTaxi(Taxi taxi)
        {
            // Логіка для видалення таксі
            Console.WriteLine($"Taxi service '{taxi.CompanyName}' removed successfully.");
        }

        public void UpdateTaxi(Taxi taxi)
        {
            // Логіка для оновлення таксі
            Console.WriteLine($"Taxi service '{taxi.CompanyName}' updated successfully.");
        }
    }

}
