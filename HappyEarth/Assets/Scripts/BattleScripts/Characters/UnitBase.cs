using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UnitBase : MonoBehaviour
{
    //Unit Stats:
    public int maxHp;
    public int curHp;
    public int attack;

    //

    public void TakeDamage(int damage)
    {
        curHp -= damage;
        if (curHp< 0) curHp = 0;
        if (curHp == 0)
        {
            Debug.Log(gameObject.name + " is dead.");
        }
    }

}
