using System.Collections.Generic;

public class Player
{
    private List<Army> armyList { get; set; }

    public Player()
    {
        armyList = new List<Army>();
    }
    public void AddArmy(Army army, Pos pos)
    {

        // create new army object
        this.armyList.Add(new Army(pos, 100));
    }

    public void MoveArmy(Army army, Pos toPos)
    {
        // TODO: Change
    }
}