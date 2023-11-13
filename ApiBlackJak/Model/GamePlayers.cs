namespace ApiBlackJak.Model;

public class GamePlayers : IPlayer
{
    public string Id { get; set; }
    public string Name { get; set; }
    public Hands Hands { get; set; }
    public int Account { get; set; }
    
    public GamePlayers(string id, string name, Hands hands, int account)
    {
        Id = id;
        Name = name;
        Hands = hands;
        Account = account;
    }
}