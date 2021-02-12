using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{
    private int level = 0;
    private bool isPurchased = false;
    [SerializeField] private string name = "Unit";
    [SerializeField] private float attack = 1;
    [SerializeField] private float attackModifier = 2;
    [SerializeField] private float purchaseCost = 20;
    [SerializeField] private float upgradeCost = 10;
    [SerializeField] private float upgradeCostModifier = 2;

    public string getName() { return this.name; }
    public int getLevel() { return this.level; }
    public float getAttack() { return this.attack; }
    public float getAttackModifier() { return this.attackModifier; }
    public float getPurchaseCost() { return this.purchaseCost; }
    public float getUpgradeCost() { return this.upgradeCost; }
    public float getUpgradeCostModifier() { return this.upgradeCostModifier; }
    public bool getIsPurchased() { return this.isPurchased; }

    public void setLevel(int level) { this.level = level; }
    public void setUpgradeCost(float upgradeCost) { this.upgradeCost = upgradeCost; }
    public void setAttack(float attack) { this.attack = attack; }
    public void setIsPurchased(bool purchaseStatus) { this.isPurchased = purchaseStatus; }
}
