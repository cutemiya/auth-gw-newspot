using fu.Microservices.BisnesLogicalService;
using Microsoft.AspNetCore.Mvc;

namespace fu.Controllers;

[Route("business")]
public class BusinessLogicalController: BaseController
{
    private readonly IBusinessLogicalService businessLogicalService;

    public BusinessLogicalController(IBusinessLogicalService businessLogicalService)
    {
        this.businessLogicalService = businessLogicalService;
    }
    
    [HttpGet("ping123")]
    public async Task<IActionResult> Ping()
    {
        return Ok(await businessLogicalService.Ping());
    }
}