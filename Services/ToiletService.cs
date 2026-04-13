using ToiletFinder3000.Model;
using ToiletFinder3000.Repository;

namespace ToiletFinder3000.Services
{
	public class ToiletService
	{
		private readonly IToiletRepository _toiletRepository;

		public ToiletService(IToiletRepository toiletRepository)
		{
			_toiletRepository = toiletRepository;
		}

		public List<Toilet> GetAllToilets()
		{
			return _toiletRepository.GetAllToilets();
		}

		public void AddToilet(Toilet toilet)
		{
			_toiletRepository.AddToilet(toilet);
		}

		public Toilet GetToiletById(string id)
		{
			return _toiletRepository.GetToiletById(id);
		}

		public void DeleteToilet(string id)
		{
			_toiletRepository.DeleteToilet(id);
		}
	}
}
