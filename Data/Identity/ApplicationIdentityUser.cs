using Microsoft.AspNetCore.Identity;

namespace WebAuthorization22.Data.Identity
{
    public class ApplicationIdentityUser : IdentityUser
    {
        public long AplicationID { get; set; }
        public int Achievement { get; set; }
    }
}
