using ToiletFinder3000.Model;

namespace ToiletFinder3000.Repository
{
	public interface IToiletRepository
	{
		public List<Toilet> GetAllToilets();
		public Toilet GetToiletById(string id);
		public void AddToilet(Toilet toilet);
		public void UpdateToilet(Toilet toilet);
		public void FindToilet(string id);
		public List<Toilet> SearchToilets(string query);
		public void DeleteToilet(string id);
	}
}
