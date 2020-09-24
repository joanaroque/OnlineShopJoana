namespace OnlineShopJoana.WEB.Helpers
{
    public interface IMailHelper 
    {
        void SendMail(string to, string subject, string body);
    }
}
