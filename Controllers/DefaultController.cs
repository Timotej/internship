using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DefaultController : ControllerBase
{
	private readonly ILogger<DefaultController> _logger;

	public DefaultController(ILogger<DefaultController> logger)
	{
		_logger = logger;
	}

	[HttpGet]
	public object Get()
	{
		_logger.LogWarning("Default controller action hit.");
		return new { message = "Hello world." };
	}
}