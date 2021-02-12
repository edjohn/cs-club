using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float gold = 0;
    [SerializeField] private float goldPerClick = 1;
    [SerializeField] private float attack = 1;

    public float getGold(){ return this.gold; }
    public float getGoldPerClick() { return this.goldPerClick; }
    public float getAttack() { return this.attack; }

    public void setGold(float gold) { this.gold = gold; }
    public void setGoldPerClick(float goldPerClick) {this.goldPerClick = goldPerClick; }
    public void setAttack(float attack) { this.attack = attack; }
}
