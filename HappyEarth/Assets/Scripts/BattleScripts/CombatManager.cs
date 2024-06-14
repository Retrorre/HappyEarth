using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CombatManager : MonoBehaviour
{
    public PlayerUnit player;
    public EnemyUnit enemy;

    private TurnManager turnManager;

    //UI
    [SerializeField] private TMP_Text playerHpText;
    [SerializeField] private TMP_Text enemyHpText;
    //

    private void Awake()
    {
        turnManager = GetComponent<TurnManager>();
        UpdateUI();
    }

    public void DealDamageToEnemy()
    {
        int playerAttackDamage = player.playerAtk;
        enemy.TakeDamage(playerAttackDamage);
        turnManager.currentTurn = TurnManager.turnType.Enemy;
        UpdateUI();
        StartCoroutine(TurnWaitTimer(2.5f));
    }

    void UpdateUI()
    {
        playerHpText.text = "HP: "+player.playerCurHp + "/" + player.playerMaxHp;
        enemyHpText.text = "HP: " + enemy.enemyCurHp+ "/" + enemy.enemyMaxHp;
    }

    void EnemiesTurn()
    {
        int enemyAttackDamage = enemy.enemyAtk;
        player.TakeDamage(enemyAttackDamage);
        turnManager.currentTurn = TurnManager.turnType.Player;
        UpdateUI();
    }

    IEnumerator TurnWaitTimer(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        EnemiesTurn();
    }
}
