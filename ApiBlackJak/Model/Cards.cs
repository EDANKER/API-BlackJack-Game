namespace ApiBlackJak.Model;

public class Cards
{
    public int King { get; set; }
    public int Lady { get; set; }
    public int Jack { get; set; }
    public int Tus { get; set; }
    public int One { get; set; }
    public int Two { get; set; }
    public int Three { get; set; }
    public int Four { get; set; }
    public int Five { get; set; }
    public int Six { get; set; }
    public int Seven { get; set; }
    public int Eight { get; set; }
    public int Nine { get; set; }
    public int Ten { get; set; }
    
    public Cards(int ten, int nine, int eight, int seven, int six, int five, int four, int three, int two, int one, int jack, int tus, int lady, int king)
    {
        Ten = ten;
        Nine = nine;
        Eight = eight;
        Seven = seven;
        Six = six;
        Five = five;
        Four = four;
        Three = three;
        Two = two;
        One = one;
        Jack = jack;
        Tus = tus;
        Lady = lady;
        King = king;
    }

}