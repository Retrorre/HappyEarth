using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : UnitBase
{
    public UnitBase _base;
    public int playerMaxHp;
    public int playerCurHp;
    public int playerAtk;
    private void Awake()
    {
        _base= GetComponent<UnitBase>();
        playerMaxHp = _base.maxHp;
        playerCurHp = playerMaxHp;
        playerAtk = _base.attack;
    }

    public void TakeDamage(int damage)
    {
        playerCurHp -= damage;
        if (playerCurHp < 0) curHp = 0;
        if (playerCurHp == 0)
        {
            Debug.Log(gameObject.name + " is dead.");
        }
    }
}
