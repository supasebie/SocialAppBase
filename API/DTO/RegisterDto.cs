namespace API.DTO
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; } = "error"!;
        [Required]
        public string Password { get; set; } = "error"!;
    }
}