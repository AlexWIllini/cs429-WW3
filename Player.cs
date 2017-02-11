using System.Collections.Generic;

public class Player
{
    private List<Army> armyList = new List<Army>();
    public List<Army> GetArmies()
    {
        int empty = 0;
        int isEmpty = armyList.Count;
        if (isEmpty == empty)
        {
            return null;
        }
        else
        {
            return armyList;
        }
    }

    public void AddArmy(Army army, Pos pos)
    {
        //create new army object
        armyList.Add(new Army());
        //add position and health to latest army object in list
        armyList[armyList.Count - 1].Position = pos;
        armyList[armyList.Count - 1].Health = 100;
    }

    public void MoveArmy(Army army, Pos toPos)
    {
        // TODO: Change
    }
}