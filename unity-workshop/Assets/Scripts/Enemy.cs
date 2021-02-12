using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private string name = "Enemy";
    [SerializeField] private float health = 100000;
    [SerializeField] private float gold = 1000;

    public float getHealth() { return this.health; }
    public float getGold() { return this.gold; }
    private string getName() { return this.name; }

    public void setHealth(float health) { this.health = health; }
}
