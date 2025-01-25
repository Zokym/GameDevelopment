using UnityEngine;

public class Move 
{
    public MoveBase moveBase { get; set; }
    public int PP {get; set; }

    public Move(MoveBase moveBase)
    {
        this.moveBase = moveBase;
        PP = moveBase.PP;
    }

}
