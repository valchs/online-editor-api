using Microsoft.AspNetCore.SignalR;
using OnlineEditor.Services.Interfaces;

namespace OnlineEditor.Services.Services;

public class SignalRHub : Hub
{
	private readonly IFileService _fileService;

	public SignalRHub(IFileService fileService)
	{
		_fileService = fileService ?? throw new ArgumentNullException(nameof(fileService));
	}
    public async Task BroadcastTextChange(string fileName, string newText, string userName)
    {
		_fileService.Update(fileName, newText);

        await Clients.Others.SendAsync("ReceiveTextChange", newText, userName);
    }
}
