using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Monster", menuName ="Monster/Create new Monster")]
public class MonsterBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;
    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] MonsterType monsterType1;
    [SerializeField] MonsterType monsterType2;

    //Base Stats
    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int speed;
    [SerializeField] int defence;
    [SerializeField] int spDefence;
    [SerializeField] int spAttack;

    [SerializeField] List<LearnableMove> learnableMoves;
    public string Name{     
        get { return name; }
    }

    public string Description
    {
        get { return description; }
    }
    public Sprite BackSprite
    {
        get { return backSprite; }
    }
    public Sprite FrontSprite
    {
        get { return frontSprite; }
    }
    public MonsterType MonsterType1
    {
        get { return monsterType1; }
    }
    public MonsterType MonsterType2
    {
        get { return monsterType2; }
    }
    public int MaxHP
    {
        get { return maxHP; }
    }
    public int Attack
    {
        get { return attack; }
    }
    public int Defence
    {
        get { return defence; }
    }
    public int SpDefence
    {
        get { return spDefence; }
    }
    public int SpAttack
    {
        get { return spAttack; }
    }
    public int Speed
    {
        get { return speed; }
    }

    public List<LearnableMove> LearnableMove
    {
        get { return learnableMoves; }
    }

}
[System.Serializable]
public class LearnableMove {
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

    public MoveBase MoveBase
    {
        get { return moveBase; }
    }
    public int Level
    {
        get { return level; }
    }
}

public enum MonsterType{

    None,
    Normal,
    Fire,
    Water,
    Grass

}
