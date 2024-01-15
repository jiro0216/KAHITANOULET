using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EquipedWeapon 
{ 
    Vandal,
    Sheriff,
    Operator

}

public class GameManager : MonoBehaviour {

    [Header("Player Stats")]
    public float basePlayerDamage;
    public float finalPlayerDamage;
    [Header("EquipedWeapon")]
    public EquipedWeapon eWeapon;
    [Header("Experience")]
    public float MAX_XP;
    public float Current_XP;
    public float EXP_to_Add;
    public int PlayerLvl;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {

            DamagePowerUp_FeedingFrenzy();
        }
    }

    private void OnValidate()
    {
        DamageSystem damageSystem = new DamageSystem();
        switch (eWeapon)
        {
            case EquipedWeapon.Vandal:
                finalPlayerDamage = basePlayerDamage + damageSystem.Damage_Vandal;
                break;
            case EquipedWeapon.Sheriff:
                finalPlayerDamage = basePlayerDamage + damageSystem.Damage_Sheriff;
                break;
            case EquipedWeapon.Operator:
                finalPlayerDamage = basePlayerDamage + damageSystem.Damage_Operator;
                break;
            default:
                break;

        }
    }

    public void DamagePowerUp_FeedingFrenzy() {

        PowerUps powerUp = new();
        finalPlayerDamage += powerUp.Feeding_Frenzy;
    }


    public void DamagePowerUp_WellFed() {

        PowerUps powerUp = new();
        float powerUpPlayerDamage = (finalPlayerDamage * (powerUp.Well_Fed / 100));
        finalPlayerDamage = powerUpPlayerDamage + finalPlayerDamage;
    }

    public void ExpSystem()
    {
        ExpHandler handler = new ExpHandler();
        MAX_XP = handler.MaxExperience;
        Current_XP = handler.CurrentExperience;
        PlayerLvl = handler.CurrentLevel;

    }

    public void AddEXP(float experienceToAdd) {

        Current_XP += experienceToAdd;

        if (Current_XP >= MAX_XP)
        {
            LevelUp();
        }

    }
    public void LevelUp()
    {
        PlayerLvl++;
        Current_XP = 0;
        MAX_XP *= 1.5f;

    }
    public void ResetValues() {

        DamageSystem damageSystem = new DamageSystem();
        switch (eWeapon) {
            case EquipedWeapon.Vandal:
                finalPlayerDamage = basePlayerDamage + damageSystem.Damage_Vandal;
                break;
            case EquipedWeapon.Sheriff:
                finalPlayerDamage = basePlayerDamage + damageSystem.Damage_Sheriff;
                break;
            case EquipedWeapon.Operator:
                finalPlayerDamage = basePlayerDamage + damageSystem.Damage_Operator;
                break;
            default:
                break;

        }
    }
}


