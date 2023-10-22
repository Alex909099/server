using System.ComponentModel.DataAnnotations.Schema;

namespace WebAuthorization22.Data.Identity
{
    [Table("Messages", Schema="data")]
    public class Message
    {
        public int ID { get; set; }
        public string Text { get; set; }

    }
}
