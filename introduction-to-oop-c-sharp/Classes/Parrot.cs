public class Parrot : Bird
{
    public Parrot(string name, string color) : base(name, color)
    {
    }

    public override void Speak() =>
        Console.WriteLine($"Squawk! Hello! Hola! Bonjour! Ciao! I'm {Name} and I'm a {Color} parrot. I speak many languages.");

}