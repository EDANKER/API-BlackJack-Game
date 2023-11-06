namespace ApiBlackJak.Model;

public class Hands
{
    public Cards Cards { get; set; }

    public Hands(Cards cards)
    {
        Cards = cards;
    }
}