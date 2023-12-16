using Microsoft.AspNetCore.Mvc;
using WebAPI.Contracts;

[Route("api/test")]
[ApiController]
public class  TestController : ControllerBase
{
    private readonly ITestRepository _testRepo;
    public TestController(ITestRepository testRepo)
    {
        _testRepo = testRepo;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var test = await _testRepo.Get();
            return Ok(test);
        }
        catch (Exception e)
        {
            
            return StatusCode(500, e.Message);
        }
    }
}