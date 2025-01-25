using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour
{
    [SerializeField] MonsterBase monsterBase;
    [SerializeField] int level;
    [SerializeField] bool isPlayerUnit;

    public Monster Monster { get; set; }

    public void Setup()
    {
        Monster = new Monster(monsterBase,level);
        if (isPlayerUnit)
        {
            GetComponent<Image>().sprite = Monster.MosterBase.BackSprite;
        }
        else
        {
            GetComponent<Image>().sprite = Monster.MosterBase.FrontSprite; 
        }
    }
}
