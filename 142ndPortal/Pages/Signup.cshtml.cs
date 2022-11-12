using _142ndPortal.Data;
using _142ndPortal.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _142ndPortal.Pages
{
    public class SignupModel : PageModel
    {
        private readonly _142ndPortalDbContext _142ndDB;

        [BindProperty]
        public RSVP AddRSVP { get; set; }

        public SignupModel(_142ndPortalDbContext _142ndDB)
        {
            this._142ndDB= _142ndDB;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            var Signup = new RSVP()
            {
                Callsign = AddRSVP.Callsign,
                Date = AddRSVP.Date,
                Confirm = AddRSVP.Confirm,
            };

            await _142ndDB.RSVP.AddAsync(Signup);
            await _142ndDB.SaveChangesAsync();

            return RedirectToPage ("/List");
        }
    }
}
