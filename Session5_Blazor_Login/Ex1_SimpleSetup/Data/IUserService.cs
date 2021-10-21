namespace Ex1_SimpleSetup.Data
{
    public interface IUserService
    {
        User ValidateUser(string username, string password);
    }
}