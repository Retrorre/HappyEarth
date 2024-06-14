using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CombatManager : MonoBehaviour
{
    public PlayerUnit player;
    public EnemyUnit enemy;

    //UI
    [SerializeField] private TMP_Text playerHpText;
    [SerializeField] private TMP_Text enemyHpText;
    //

    private void Awake()
    {
        UpdateUI();
    }

    public void DealDamageToEnemy()
    {
        int playerAttackDamage = player.playerAtk;
        enemy.TakeDamage(playerAttackDamage);
        UpdateUI();
    }

    void UpdateUI()
    {
        playerHpText.text = "HP: "+player.playerCurHp + "/" + player.playerMaxHp;
        enemyHpText.text = "HP: " + enemy.enemyCurHp+ "/" + enemy.enemyMaxHp;
    }
}
