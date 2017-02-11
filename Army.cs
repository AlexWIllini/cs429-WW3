public class Army
{
    public Pos Position { get; set; }

    public int Range { get; }

    public int Health { get; set; }

    public Army(Pos position, int health)
    {
        this.Position = position;
        this.Health = health;
    }
}