using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RollOffApi.DTO
{
    public class Usertable
    {
        [Key]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Roll { get; set; }
    }
}
