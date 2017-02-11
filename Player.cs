using System.Collections.Generic;

public class Player
{
    private List<Army> armyList = new List<Army>();
    public List<Army> GetArmies()
    {

        return this.armyList;
    }
    public void AddArmy(Army army, Pos pos)
    {

        // create new army object
        this.armyList.Add(new Army());

        // add position and health to latest army object in list
        this.armyList[this.armyList.Count - 1].Position = pos;
        this.armyList[this.armyList.Count - 1].Health = 100;
    }

    public void MoveArmy(Army army, Pos toPos)
    {
        // TODO: Change
    }
}