namespace ApiBlackJak.Model;

public class Diller
{
    public int Id { get; set; }
    public Hands Hands { get; set; }
    
    public Diller(int id, Hands hands)
    {
        Id = id;
        Hands = hands;
    }

}