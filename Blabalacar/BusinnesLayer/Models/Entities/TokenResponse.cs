namespace BusinnesLayer.Models.Entities;

public class TokenResponse
{
    // public string AccessToken { get; set; }
    // public string RefreshToken { get; set; }
    //
    // public TokenResponse(string accessToken, string refreshToken)
    // {
    //     AccessToken = accessToken;
    //     RefreshToken = refreshToken;
    // }
    public string Role { get; set; }

    public TokenResponse(string role)
    {
        Role = role;
    }
}