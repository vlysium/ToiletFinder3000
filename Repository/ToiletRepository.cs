using ToiletFinder3000.Model;

namespace ToiletFinder3000.Repository
{
	public class ToiletRepository : IToiletRepository
	{

		private List<Toilet> _toilets;

		public ToiletRepository()
		{
			_toilets = new List<Toilet>();
		}
		public List<Toilet> GetAllToilets()
		{
			return _toilets;
		}

		public Toilet GetToiletById(string id)
		{
			throw new NotImplementedException();
		}

		public void AddToilet(Toilet toilet)
		{
			throw new NotImplementedException();
		}

		public void UpdateToilet(Toilet toilet)
		{
			throw new NotImplementedException();
		}

		public void FindToilet(string id)
		{
			throw new NotImplementedException();
		}

		public Toilet SearchToilet(string query)
		{
			throw new NotImplementedException();
		}

		public void DeleteToilet(string id)
		{
			throw new NotImplementedException();
		}
	}
}
