namespace ShopCET46.WEB.Helpers
{
    public interface IMailHelper 
    {
        void SendMail(string to, string subject, string body);
    }
}
