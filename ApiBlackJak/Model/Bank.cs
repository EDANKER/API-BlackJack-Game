namespace ApiBlackJak.Model;

public class Bank
{
    public string Id { get; set; }
    public int Account { get; set; }
    
    public Bank(string id, int account)
    {
        Id = id;
        Account = account;
    }

}