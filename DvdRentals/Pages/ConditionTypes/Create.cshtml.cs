using DvdRentals.Contexts;
using DvdRentals.Models;
using DvdRentals.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DvdRentals.Pages.ConditionTypes
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ConditionTypeVm Vm { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existingObj = _context.ConditionTypes.Where(m=>m.Name == Vm.Name).FirstOrDefault();
                    if (existingObj != null)
                    {
                        ModelState.AddModelError("Vm.Name", "A record with the name provided already exist.");
                        return Page();
                    }
                    var model = new ConditionType()
                    {
                        Name = Vm.Name,
                        Description = Vm.Description
                    };

                    _context.ConditionTypes.Add(model);
                    await _context.SaveChangesAsync();
                    Message = "Data Saved!";
                }
                else
                {
                    Message = "Something Wrong!";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }

            return RedirectToPage();
        }
    }
}
