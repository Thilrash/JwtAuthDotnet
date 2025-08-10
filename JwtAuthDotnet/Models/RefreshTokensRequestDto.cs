namespace JwtAuthDotnet.Models
{
    public class RefreshTokensRequestDto
    {
        public Guid UserId { get; set; }
        public required string RefreshToken { get; set; }
    }
}
