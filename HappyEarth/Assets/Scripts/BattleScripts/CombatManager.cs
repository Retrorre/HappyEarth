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

    public void DealDamageToEnemy()
    {
        int playerAttackDamage = player.attack;
        enemy.TakeDamage(playerAttackDamage);
        UpdateUI();
    }

    void UpdateUI()
    {
        playerHpText.text = player.curHp + "/" + player.maxHp;
        enemyHpText.text = enemy.curHp+ "/" + enemy.maxHp;
    }
}
