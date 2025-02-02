using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Monster 
{
    public MonsterBase MosterBase { get; set; }
    public int Level { get; set; }
    public int HP {get; set;}

    public List<Move> Moves { get; set; }

    public Monster(MonsterBase monsterBase, int level)
    {
        this.MosterBase = monsterBase;
        this.Level = level; 
        HP = MaxHP;

        //Generate Move
        Moves = new List<Move>();
        foreach (var move in monsterBase.LearnableMove)
        {
            if (move.Level <= level)
            {
                Moves.Add(new Move(move.MoveBase));

                if (Moves.Count >= 4)
                {
                    break;
                }
            }
        }

    }

    public int Attack
    {
        get { return Mathf.FloorToInt((MosterBase.Attack * Level) / 100f) + 5; }
    }

    public int MaxHP
    {
        get { return Mathf.FloorToInt((MosterBase.MaxHP * Level) / 100f) + 10; }
    }
    public int Defence
    {
        get { return Mathf.FloorToInt((MosterBase.Defence * Level) / 100f) + 5; }
    }
    public int SpDefence
    {
        get { return Mathf.FloorToInt((MosterBase.SpDefence * Level) / 100f) + 5; }
    }
    public int SpAttack
    {
        get { return Mathf.FloorToInt((MosterBase.SpAttack * Level) / 100f) + 5; }
    }
    public int Speed
    {
        get { return Mathf.FloorToInt((MosterBase.Speed * Level) / 100f) + 5; }
    }

    public bool TakeDamage(Move move, Monster attacker)
    {
        float modifiers = Random.Range(0.8f, 1f);
        float a = (2 * attacker.Level + 10) / 250f;
        float d = a * move.moveBase.Power * ((float)attacker.Attack / Defence) + 2;
        int dmage = Mathf.FloorToInt(d * modifiers);

        HP -= dmage;
        if (HP <= 0)
        {
            HP = 0;
            return true;
        }
        else
        {
            return false;
        }

    }

    public Move GetRandomMove()
    {
        int r = Random.Range(0,Moves.Count);
        return Moves[r];
    }
}
