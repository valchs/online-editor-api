using OnlineEditor.Models.Files;
using OnlineEditor.Repository.Files;
using OnlineEditor.Services.Interfaces;

namespace OnlineEditor.Services.Services;

public class FileService : IFileService
{
	private readonly IFileRepository _fileRepository;

	public FileService(IFileRepository fileRepository)
	{
		_fileRepository = fileRepository ?? throw new ArgumentNullException(nameof(fileRepository));
	}

	public List<FileModel> Get()
	{
		return _fileRepository.Get();
	}

	public FileModel GetByName(string fileName)
	{
		return _fileRepository.GetByName(fileName);
	}

	public void Update(string fileName, string data)
	{
		_fileRepository.Update(fileName, data);
	}
}
