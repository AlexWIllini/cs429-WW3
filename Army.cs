public class Army
{
    public Pos Position { get; set; }

    public int Range { get; }

    public int Health { get; set; }

    public Army(Pos Position, int Health)
    {
        this.Position = Position;
        this.Health = Health;
    }
}