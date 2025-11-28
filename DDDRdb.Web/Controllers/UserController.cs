using Microsoft.AspNetCore.Mvc;
using DDDRdb.Core.Interfaces;

namespace DDDRdb.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _repo;

        public UserController(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _repo.GetAllAsync();
            return View(data);
        }
    }
}
