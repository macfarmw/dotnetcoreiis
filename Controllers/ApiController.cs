using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NamespaceName
{

  [Route("api")]
  public class ControllerNameController : Controller
  {

    ILogger<ControllerNameController> _logger;

    public ControllerNameController(ILogger<ControllerNameController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
      try
      {
        return Ok();
      }
      catch (Exception)
      {
        _logger.LogError("Failed to execute GET");
        return BadRequest();
      }
    }

    [HttpPost]
    public IActionResult Post([FromBody] modelType model)
    {
      try
      {
        return Created("", null);
      }
      catch (Exception)
      {
        _logger.LogError("Failed to execute POST");
        return BadRequest();
      }
    }

    [HttpPut]
    public IActionResult Put([FromBody] modelType model)
    {
      try
      {
        return Ok();
      }
      catch (Exception)
      {
        _logger.LogError("Failed to execute PUT");
        return BadRequest();
      }
    }

    [HttpDelete]
    public IActionResult Delete(inputType id)
    {
      try
      {
        return Ok();
      }
      catch (Exception)
      {
        _logger.LogError("Failed to execute DELETE");
        return BadRequest();
      }
    }
  }
}