using Kolokwium_APBD_s31896.Exceptions;
using Kolokwium_APBD_s31896.Models.DTOs;
using Kolokwium_APBD_s31896.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium_APBD_s31896.Controllers;

[ApiController]
[Route("politycy")]
public class PolitycyController(IDbService dbService) : ControllerBase
{
    [HttpGet] //wypisz wszystkich politykow z bazy
    public async Task<IActionResult> GetAllTrips()
    {
        try
        {
            return Ok(await dbService.GetPolitykDetailsAsync());
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
    
    [HttpPut("")]
    public async Task<IActionResult> AddPolityk([FromQuery] PolitykCreateDTO polityk, List<string>? partie)
    {
        try
        {
            return Ok(await dbService.AddPolitykAsync(polityk, partie));
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
}