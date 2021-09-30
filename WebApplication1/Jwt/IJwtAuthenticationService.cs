namespace WebApplication1.Jwt
{
    public  interface IJwtAuthenticationService
    {
        string Authenticate(string username, string password);
    }
}