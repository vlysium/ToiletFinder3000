using ToiletFinder3000.Model;

namespace ToiletFinder3000.Repository
{
	public class ToiletRepository : IToiletRepository
	{

		private List<Toilet> _toilets;

		public ToiletRepository()
		{
			_toilets = new List<Toilet>();

			Address address1 = new Address("Lyngvej 21", "4600", "Køge");
			Toilet toilet1 = new Toilet(Guid.NewGuid().ToString(), "Skibidi toilet", address1);
			_toilets.Add(toilet1);

			Address address2 = new Address("Maglegårdsvej 2", "4000", "Roskilde");
			Toilet toilet2 = new Toilet(Guid.NewGuid().ToString(), "Six-seven toilet", address2);
			_toilets.Add(toilet2);

			Address address3 = new Address("Bispegade 5", "4800", "Nykøbing Falster");
			Toilet toilet3 = new Toilet(Guid.NewGuid().ToString(), "Unc Toilet", address3);
			_toilets.Add(toilet3);

			Address address4 = new Address("Femøvej 3", "4160", "Næstved");
			Toilet toilet4 = new Toilet(Guid.NewGuid().ToString(), "Gigachad Toilet", address4);
			_toilets.Add(toilet4);

			Address address5 = new Address("Bredahlsgade 1A", "4200", "Slagelse");
			Toilet toilet5 = new Toilet(Guid.NewGuid().ToString(), "Goofy Toilet", address5);
			_toilets.Add(toilet5);

			Address address6 = new Address("Anders Larsensvej 7-9", "4300", "Holbæk");
			Toilet toilet6 = new Toilet(Guid.NewGuid().ToString(), "Bruh Toilet", address6);
			_toilets.Add(toilet6);
		}
		public List<Toilet> GetAllToilets()
		{
			return _toilets;
		}

		public Toilet GetToiletById(string id)
		{
			foreach (Toilet toilet in _toilets)
			{
				if (toilet.Id == id)
				{
					return toilet;
				}
			}
			throw new Exception("Toilet not found");
		}

		public void AddToilet(Toilet toilet)
		{
			_toilets.Add(toilet);
		}

		public void UpdateToilet(Toilet toilet)
		{
			throw new NotImplementedException();
		}

		public void FindToilet(string id)
		{
			throw new NotImplementedException();
		}

		public List<Toilet> SearchToilets(string query)
		{
			List<Toilet> results = new List<Toilet>();
			foreach (Toilet toilet in _toilets)
			{
				if (toilet.NickName.ToLower().Contains(query.ToLower()))
				{
					results.Add(toilet);
				}
			}
			return results;
		}

		public void DeleteToilet(string id)
		{
			foreach (Toilet toilet in _toilets)
			{
				if (toilet.Id == id)
				{
					_toilets.Remove(toilet);
					return;
				}
			}
			throw new Exception("Toilet not found");
		}
	}
}
