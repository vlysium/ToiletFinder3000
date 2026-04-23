namespace ToiletFinder3000.Model
{
	public class Address
	{
		private string _street;
		// private string _number;
		private string _postalCode;
		private string _city;
		private double _longitude;
		private double _latitude;

		public string Street { get => _street; set => _street = value; }
		// public string Number { get => _number; set => _number = value; }
		public string PostalCode { get => _postalCode; set => _postalCode = value; }
		public string City { get => _city; set => _city = value; }
		public double Longitude { get => _longitude; set => _longitude = value; }
		public double Latitude { get => _latitude; set => _latitude = value; }

		public Address(): this(string.Empty, /* string.Empty, */ string.Empty, string.Empty)
		{
			
		}

		public Address(string street, /* string number, */ string postalCode, string city)
		{
			_street = street;
			// _number = number;
			_postalCode = postalCode;
			_city = city;
		}

		public Address(string street, /* string number, */ string postalCode, string city, double longitude, double latitude)
			: this(street, /* number ,*/ postalCode, city)
		{
			_longitude = longitude;
			_latitude = latitude;
		}

		public override string ToString()
		{
			return $"{Street}, {PostalCode} {City}, Longitude: {Longitude}, Latitude: {Latitude}";
		}
	}
}
