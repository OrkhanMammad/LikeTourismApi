namespace ServiceLayer.DTOs.AppUser
{
    public class ResetPasswordDto
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
