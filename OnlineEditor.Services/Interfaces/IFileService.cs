using OnlineEditor.Models.Files;

namespace OnlineEditor.Services.Interfaces
{
	public interface IFileService
	{
		List<FileModel> Get();
		FileModel GetByName(string fileName);
		void Update(string fileName, string data);
	}
}
