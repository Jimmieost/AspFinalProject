using AspFinalProject.Models.ViewModels;
using AspFinalProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AspFinalProject.Controllers
{
    public class ContactsController : Controller
    {

        private readonly ContactRepository _contactRepository;

        public ContactsController(ContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                await _contactRepository.AddAsync(new Models.Entities.ContactEntity
                {
                    Name = viewModel.Name,
                    Email = viewModel.Email,
                    Message = viewModel.Message,
                });

                return RedirectToAction("Index");

            }

            return View(viewModel);
        }




    }
}
