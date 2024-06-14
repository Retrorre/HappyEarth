using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : UnitBase
{
    public UnitBase _base;
    public int enemyMaxHp;
    public int enemyCurHp;
    public int enemyAtk;
    private void Awake()
    {
        _base = GetComponent<UnitBase>();
        enemyMaxHp = _base.maxHp;
        enemyCurHp = enemyMaxHp;
        enemyAtk = _base.attack;
    }

    public void TakeDamage(int damage)
    {
        enemyCurHp -= damage;
        if (enemyCurHp < 0) curHp = 0;
        if (enemyCurHp == 0)
        {
            Debug.Log(gameObject.name + " is dead.");
        }
    }
}
