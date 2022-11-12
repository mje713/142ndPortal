using _142ndPortal.Data;
using _142ndPortal.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.AccessControl;

namespace _142ndPortal.Pages
{
    public class ListModel : PageModel
    {
        private readonly _142ndPortalDbContext _142ndDb;
        public List<RSVP> RSVPs { get; set; }

        public ListModel(_142ndPortalDbContext _142ndDb)
        {
            this._142ndDb = _142ndDb;
        }
        public void OnGet()
        {
            RSVPs = _142ndDb.RSVP.ToList();
        }
    }
}
