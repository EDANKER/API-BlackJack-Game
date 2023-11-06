namespace ApiBlackJak.Model;

public class Spectator : IPlayer
{
    public string Id { get; set; }
    public string Name { get; set; }
    
    public Spectator(string id, string name)
    {
        Id = id;
        Name = name;
    }

}