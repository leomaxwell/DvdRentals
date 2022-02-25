using DvdRentals.Contexts;
using DvdRentals.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace DvdRentals.Pages.ConditionTypes
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<ConditionTypeVm> VMs { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {
            VMs = new List<ConditionTypeVm>();

            var models = _context.ConditionTypes.Select(m => new
            {
                Id = m.Id,
                Name = m.Name,
                Description = m.Description
            }).ToList();

            foreach (var vm in models)
            {
                var m = new ConditionTypeVm() {Id = vm.Id, Name = vm.Name, Description = vm.Description };
                VMs.Add(m);
            }
        }
    }
}