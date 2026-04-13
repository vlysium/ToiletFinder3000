namespace ToiletFinder3000.Model
{
	public class Toilet
	{
		private string _id;
		private string _nickName;
		private double _rating;
		private Address _address;
		public string Id { get => _id; set => _id = value; }
		public string NickName { get => _nickName; set => _nickName = value; }
		public double Rating { get => _rating; set => _rating = value; }
		public Address Address { get => _address; set => _address = value; }

		public Toilet(string id, string nickName, Address address)
		{
			_id = id;
			_nickName = nickName;
			_address = address;
		}

		public override string ToString()
		{
			return $"Toilet: {Id}, Nickname: {NickName}, Address: {Address}";
		}
	}
}
