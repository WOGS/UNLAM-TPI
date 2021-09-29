namespace WebApplication1
{
    public  interface IJwtAuthenticationService
    {
        string Authenticate(string username, string password);
    }
}