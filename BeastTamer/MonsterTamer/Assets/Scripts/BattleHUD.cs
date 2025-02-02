using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;
using System.Collections;



public class BattleHUD : MonoBehaviour
{
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text levelText;
    [SerializeField] HPBar hpBar;
    
    Monster _monster;

    public void SetData(Monster monster)
    {
        _monster = monster;
        nameText.text = monster.MosterBase.Name;
        levelText.text = "Lvl " + monster.Level;
        hpBar.SetHP((float)monster.HP / monster.MaxHP);
    }

    public IEnumerator UpdateHP()
    {
       yield return hpBar.SetHPSmooth((float)_monster.HP / _monster.MaxHP);
    }


}
