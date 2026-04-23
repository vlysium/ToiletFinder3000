using System.Text.Json;
using ToiletFinder3000.Model;

namespace ToiletFinder3000.Repository
{
	public class ToiletJSONRepository : IToiletRepository
	{
		private readonly string path = @"Data/toilets.json";
		List<Toilet> toilets = new List<Toilet>();

		public ToiletJSONRepository()
		{
			if (File.Exists(path))
			{
				LoadToiletsFromFile();
			}
		}

		private void LoadToiletsFromFile()
		{
			string json = File.ReadAllText(path);
			toilets = JsonSerializer.Deserialize<List<Toilet>>(json) ?? new List<Toilet>();
		}

		private void SaveToiletsToFile()
		{
			string json = JsonSerializer.Serialize(toilets);
			File.WriteAllText(path, json);
		}

		public void AddToilet(Toilet toilet)
		{
			toilets.Add(toilet);
			SaveToiletsToFile();
		}

		public void DeleteToilet(string id)
		{
			foreach (Toilet toilet in toilets)
			{
				if (toilet.Id == id)
				{
					toilets.Remove(toilet);
					SaveToiletsToFile();
					return;
				}
			}
			throw new Exception("Toilet not found");
		}

		public void FindToilet(string id)
		{
			throw new NotImplementedException();
		}

		public List<Toilet> GetAllToilets()
		{
			return toilets;
		}

		public Toilet GetToiletById(string id)
		{
			foreach (Toilet toilet in toilets)
			{
				if (toilet.Id == id)
				{
					return toilet;
				}
			}
			throw new Exception("Toilet not found");
		}

		public List<Toilet> SearchToilets(string query)
		{
			List<Toilet> results = new List<Toilet>();
			foreach (Toilet toilet in toilets)
			{
				if (toilet.NickName.ToLower().Contains(query.ToLower()))
				{
					results.Add(toilet);
				}
			}
			return results;
		}

		public void UpdateToilet(Toilet toilet)
		{
			throw new NotImplementedException();
		}
	}
}
