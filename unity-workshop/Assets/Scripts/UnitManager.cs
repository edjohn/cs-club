using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitManager : MonoBehaviour
{
    [SerializeField] private PlayerManager playerManager;
    [SerializeField] private Player player;
    [SerializeField] private GameObject unitUI;
    [SerializeField] private GameObject purchaseSound;
    [SerializeField] private GameObject upgradeSound;

    private GameObject unitStats;
    private GameObject unitSprite;
    private GameObject unitNametag;
    private Unit unit;

    void Start()
    {
        unitStats = unitUI.transform.Find("Stats").gameObject;
        unitSprite = unitUI.transform.Find("Sprite").gameObject;
        unitNametag = unitUI.transform.Find("Nametag").gameObject;
        unit = unitUI.transform.Find("Unit").gameObject.GetComponent<Unit>();

        unitStats.GetComponent<Text>().text = $"[PURCHASE]\nCOST: {unit.getPurchaseCost()}";
        unitNametag.GetComponent<Text>().text = unit.getName();
    }

    private void playUpgradeSound()
    {
        upgradeSound.GetComponent<AudioSource>().Play();
    }

    private void playPurchaseSound()
    {
        purchaseSound.GetComponent<AudioSource>().Play();
    }

    private void buffPlayerAttack()
    {
        player.setAttack(player.getAttack() + unit.getAttack());
        playerManager.updatePlayerStatsUI();
    }

    private void unlock()
    {
        unitSprite.GetComponent<Image>().color = Color.white;
        unit.setIsPurchased(true);
    }

    public void updateUnitUI()
    /*
    Create a string variable "stats" that looks like this (substitute real values inside brackets)
    ATTACK: [unit attack value]
    UPGRADE: [unit upgrade cost]

    Bonus: The Mathf.Round() function takes a float and rounds it to an integer, which makes your numbers neater to display
    */
    {
        //CODE WITHIN THESE LINES

        //CODE WITHIN THESE LINES

        unitStats.GetComponent<Text>().text = stats;
    }

    public void upgrade()
    /*
    Case 1: The player cannot afford the purchase cost OR the upgrade cost
            1. Do not proceed to the other two cases
    Case 2: The player has not purchased the unit and can afford the upgrade cost
            1. Subtract the purchase cost from the player's gold
            2. Call a function that'll unlock the unit (hint: its in this file)
            3. Call a function that'll buff the unit's attack (hint: its in this file)
            4. Call a function that'll play a purchase sound (hint: its in this file)
    Case 3: The player has purchased the unit and can afford the upgrade
            1. Subtract the purchase cost from the player's gold
            2. Increment the unit's level by one
            3. Multiply the unit's attack by its attack modifier
            4. Multiply the unit's upgrade cost by its upgrade cost modifier
            5. Call a function that'll buff the player's attack (hint: its in this file)
            6. Call a function that'll play an upgrade sound (hint: its in this file)
    */
    {
        //CODE WITHIN THESE LINES

            
        //CODE WITHIN THESE LINES

        player.setGoldPerClick(player.getGoldPerClick() + 1);
        updateUnitUI();
    }

    
}
