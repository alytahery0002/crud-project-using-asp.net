using Microsoft.AspNetCore.Mvc;
using YourProject.Models;
using YourProject.Services;


[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _service;
    public CategoriesController(ICategoryService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var category = await _service.GetByIdAsync(id);
        return category == null ? NotFound() : Ok(category);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Category category)
    {
        var created = await _service.CreateAsync(category);
        return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
    }
}


//[ApiController]
//[Route("api/[controller]")]
//public class UsersController : ControllerBase
//{
//    private readonly IUserService _service;
//    public UsersController(IUserService service) => _service = service;

//    [HttpGet]
//    public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

//    [HttpGet("{id}")]
//    public async Task<IActionResult> Get(int id)
//    {
//        var user = await _service.GetByIdAsync(id);
//        return user == null ? NotFound() : Ok(user);
//    }

//    [HttpPost]
//    public async Task<IActionResult> Create(User user)
//    {
//        var created = await _service.CreateAsync(user);
//        return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
//    }
//}