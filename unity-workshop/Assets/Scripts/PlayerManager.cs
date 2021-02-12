using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private GameObject playerStats;

    // Start is called before the first frame update
    void Start()
    {
        updatePlayerStatsUI();
    }

    public void updatePlayerStatsUI()
    /*
    Create a string variable "stats" that looks like this (substitute real values inside brackets)
    ATTACK: [player attack value]
    GOLD: [player gold value]
    GOLD/CLICK: [player gold/click value]

    Bonus: The Mathf.Round() function takes a float and rounds it to an integer, which makes your numbers neater to display
    */
    {
        //CODE WITHIN THESE LINES

        //CODE WITHIN THESE LINES

        playerStats.GetComponent<Text>().text = stats;
    }
}
