using System;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleHUD playerHud;
    [SerializeField] BattleUnit enemyUnit;
    [SerializeField] BattleHUD enemyHud;

    private void Start()
    {
        SetupBattle();
    }

    private void SetupBattle()
    {
        enemyUnit.Setup();
        playerUnit.Setup();
        enemyHud.SetData(enemyUnit.Monster);
        playerHud.SetData(playerUnit.Monster);
    }
}
