using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StatsPlayer : MonoBehaviour
{
    public float damage;
    public float manacost;

    public float healthMax;
    public float healthNow;
    public float healthReg;

    public float expMax;
    public float expNow;
    public int lvl = 1;

    public float manaMax;
    public float manaNow;
    public float manaReg;

    public int gold;
    public int soul;

    public int strength;
    public int dexterity;
    public int intellect;

    public HealthBar healthBar;
    public ManaBar manaBar;
    public ExpBar expBar;

    public TextMeshProUGUI goldInfo;
    public TextMeshProUGUI soulInfo;
    public TextMeshProUGUI lvlInfo;

    void Start()
    {
        manaNow = manaMax;
        healthNow = healthMax;
        healthBar.SetMaxHealth(healthMax);
        manaBar.SetMaxMana(manaMax);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TakeDamege(10);

        ManaHp();

        if (expNow >= expMax)
            LvlUp();
        if (healthNow <= 0)
            Death();
    }

    public void Death()
    {
        SceneManager.LoadScene(0);
    }

    public void TakeDamege(float damageMob)
    {
        healthNow -= damageMob;
        healthBar.SetHealth(healthNow);
    }

    public void DealingDamage()
    {
        manaNow -= manacost;
        manaBar.SetMana(manaNow);
    }

    public void TakeExp(float takeExp)
    {
        expNow += takeExp;
        expBar.SetExp(expNow);
    }

    public void TakeGold(int takeGold)
    {
        gold += takeGold;
        goldInfo.text = gold.ToString();
    }

    public void TakeSoul(int takeSoul)
    {
        soul += takeSoul;
        soulInfo.text = soul.ToString();
    }

    public void ManaHp()
    {
        if (manaNow < manaMax - manaReg)
            manaNow += manaReg;
        if (healthNow < healthMax - healthReg)
            healthNow += healthReg;
        manaBar.SetMana(manaNow);
        healthBar.SetHealth(healthNow);
    }

    public void LvlUp()
    {
        GameObject.FindGameObjectWithTag("SoundManeger").GetComponent<SoundManegerGame>().PlaySound(1);

        expNow -= expMax;

        lvl++;
        
        healthMax += 10;
        manaMax += 10;
        expMax += 100*lvl;
        damage += 1;

        healthNow = healthMax;
        manaNow = manaMax;
        
        healthBar.SetMaxHealth(healthMax);

        expBar.SetMaxExp(expMax);
        expBar.SetExp(expNow);

        manaBar.SetMaxMana(manaMax);

        lvlInfo.text = lvl.ToString();
    }
}
