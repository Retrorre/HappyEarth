using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    //enum to represent the turn stage.
    public enum turnType
    {
        Player,
        Enemy
    }

    [SerializeField] private turnType currentTurn;
    // end of turn enum.

    public static bool isPlayerTurn;

    // text variables.
    [SerializeField] private TMP_Text turnDisplayText;

    //
    // Buttons
    [SerializeField] Button attackButton;
    //
    private void Start()
    {
        currentTurn = turnType.Player;
    }

    private void Awake()
    {
        // getting all the units on the battlefield
        UnitBase[] _unitsInScene = FindObjectsOfType<UnitBase>();

        foreach (UnitBase unit in _unitsInScene)
        {
            GameObject obj = unit.gameObject;

            Debug.Log ("Found Object: "+ obj.name);
        }
    }

    private void Update()
    {
        CheckTurn();
    }

    private void CheckTurn()
    {
        turnDisplayText.text = "Current turn: " + currentTurn.ToString();

        if (currentTurn == turnType.Player)
        {
            isPlayerTurn = true;
            attackButton.interactable = true;
        }
        else if (currentTurn == turnType.Enemy)
        {
            isPlayerTurn = false;
            attackButton.interactable = false;
        }
    }

}
