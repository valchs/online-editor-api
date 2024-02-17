using Microsoft.AspNetCore.Mvc;
using OnlineEditor.Models.Files;
using OnlineEditor.Services.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace OnlineEditorAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FilesController : ControllerBase
	{
		private readonly IFileService _fileService;

		public FilesController(IFileService fileService)
		{
			_fileService = fileService ?? throw new ArgumentNullException(nameof(fileService));
		}

        [SwaggerOperation(description: "Get list of files")]
        [SwaggerResponse(200, "Files are retrieved", typeof(List<string>))]
        [HttpGet]
        public IActionResult Get()
        {
            List<FileModel> files = _fileService.Get();

            return Ok(files);
        }

        [SwaggerOperation(description: "Get JSON file")]
        [SwaggerResponse(200, "File is retrieved", typeof(string))]
        [HttpGet("{name}")]
        public IActionResult GetFileData(string name)
        {
			try
			{
				FileModel file = _fileService.GetByName(name);

				return Ok(file.Data);
			}
			catch (Exception)
			{
				return BadRequest("File not found");
			}
        }
    }
}
