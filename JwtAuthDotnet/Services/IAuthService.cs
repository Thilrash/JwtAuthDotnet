using JwtAuthDotnet.Entities;
using JwtAuthDotnet.Models;

namespace JwtAuthDotnet.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<TokenResponseDto?> LoginAsync(UserDto request);
        Task<TokenResponseDto?> RefreshTokenAsync(RefreshTokensRequestDto request);
    }
}
