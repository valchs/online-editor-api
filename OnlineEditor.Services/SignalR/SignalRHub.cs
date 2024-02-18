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

	public async Task JoinFileGroup(string fileName)
	{
		await Groups.AddToGroupAsync(Context.ConnectionId, fileName);
	}

	public async Task LeaveFileGroup(string fileName)
	{
		await Groups.RemoveFromGroupAsync(Context.ConnectionId, fileName);
	}

	public async Task BroadcastTextChange(string fileName, string newText, string userName)
    {
		_fileService.Update(fileName, newText);

		await Clients.Group(fileName).SendAsync("ReceiveTextChange", newText, userName);
    }
}
