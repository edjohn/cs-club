using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private PlayerManager playerManager;
    [SerializeField] private GameObject enemyStats;
    [SerializeField] private GameObject damageSound;
    [SerializeField] private GameObject deathSound;

    // These are the variables you'll be using when writing functions
    [SerializeField] private Player player;
    [SerializeField] private Enemy enemy;

    void Start()
    {
        updateEnemyStatsUI();
    }

    private void playDamageSound()
    {
        damageSound.GetComponent<AudioSource>().Play();
    }

    private void playDeathSound()
    {
        deathSound.GetComponent<AudioSource>().Play();
    }

    private void handleDeath()
    /*
    1. Increase the player's gold by the enemy's gold value.
    2. Call a function that'll play a death sound (hint: its in this file)
    */
    {
        //CODE WITHIN THESE LINES
        player.setGold(enemy.getGold() + player.getGold());
        playDeathSound();
        //CODE WITHIN THESE LINES

        Destroy(enemy.gameObject);
    }

    public void updateEnemyStatsUI()
    /*
    Create a string variable "stats" that looks like this (substitute real values inside brackets)
    HEALTH: [enemy health value]
    GOLD: [enemy gold value]
    */
    {
        //CODE WITHIN THESE LINES
        string stats = $"HEALTH: {enemy.getHealth()}\n GOLD: {enemy.getGold()}";
        //CODE WITHIN THESE LINES

        enemyStats.GetComponent<Text>().text = stats;
    }

    public void takeDamage()
    /*
    1. Give the player gold equivalent to their gold/click.
    2. Make the enemy lose health equivalent to the player's attack.
    3. If the enemy has no (or negative!) health, call a function that'll "handle" the death (hint: its in this file)
    4. Call a function that'll play a damage sound (hint: its in this file)
    */
    {
        //CODE WITHIN THESE LINES
        float enemyHealth = enemy.getHealth();

        player.setGold(player.getGold() + player.getGoldPerClick());
        enemy.setHealth(enemyHealth - player.getAttack());
        if (enemyHealth <= 0)
        {
            handleDeath();
        }
        playDamageSound();
        //CODE WITHIN THESE LINES

        updateEnemyStatsUI();
        playerManager.updatePlayerStatsUI();
    }
}

