namespace JWTwebApi.Models
{
    public class User
    {
        public string UserName { get; set; } = string.Empty;
        public string PassWordHash { get; set; } = string.Empty;
    }
}
