using OnlineEditor.Models.Files;

namespace OnlineEditor.Repository.Files;

public interface IFileRepository
{
    List<FileModel> Get();
    FileModel GetByName(string name);
    void Update(string fileName, string data);
}
