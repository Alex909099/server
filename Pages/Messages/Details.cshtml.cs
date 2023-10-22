using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAuthorization22.Data;
using WebAuthorization22.Data.Identity;

namespace WebAuthorization22.Areas.Identity.Pages.Account.Messages
{
    public class DetailsModel : PageModel
    {
        private readonly WebAuthorization22.Data.ApplicationDbContext _context;

        public DetailsModel(WebAuthorization22.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Message Message { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Messages == null)
            {
                return NotFound();
            }

            var message = await _context.Messages.FirstOrDefaultAsync(m => m.ID == id);
            if (message == null)
            {
                return NotFound();
            }
            else 
            {
                Message = message;
            }
            return Page();
        }
    }
}
