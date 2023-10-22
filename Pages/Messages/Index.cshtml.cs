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
    public class IndexModel : PageModel
    {
        private readonly WebAuthorization22.Data.ApplicationDbContext _context;

        public IndexModel(WebAuthorization22.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Message> Message { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Messages != null)
            {
                Message = await _context.Messages.ToListAsync();
            }
        }
    }
}
