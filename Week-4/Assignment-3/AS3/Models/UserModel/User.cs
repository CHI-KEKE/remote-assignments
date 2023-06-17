using System.ComponentModel.DataAnnotations;

namespace AS3.Models.UserModel
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
