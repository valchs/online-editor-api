using OnlineEditor.Models.Files;

namespace OnlineEditor.Repository.Files;

public class FileRepository : IFileRepository
{
	public List<FileModel> Get()
	{
		return MockDatabase.Files;
	}

	public FileModel GetByName(string name)
	{
		return MockDatabase.Files.FirstOrDefault(f => f.Name == name);
	}

	public void Update(string fileName, string data)
	{
		var file = MockDatabase.Files.FirstOrDefault(f => f.Name.Equals(fileName, StringComparison.OrdinalIgnoreCase));

		if (file != null)
		{
			file.Data = data;
		}
	}
}
