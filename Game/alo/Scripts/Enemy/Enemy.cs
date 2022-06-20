using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Slider slider;

    public float health;
    public float healthMax;
    public float expDrop;
    public int goldDrop;
    public int soulDrop;
    public float damage;

    System.Random rnd = new System.Random();
    public StatsPlayer player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<StatsPlayer>();
        slider.maxValue = healthMax;
    }
    public void TakeDamege(float damage)
    {
        health -= damage;
        slider.value = health;
        if (health <= 0)
        {
            DestroyEnemy();
        }        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<StatsPlayer>().TakeDamege(damage);
        }
    }

    public void DestroyEnemy()
    {
        goldDrop = rnd.Next(goldDrop, goldDrop + 10);
        soulDrop = rnd.Next(soulDrop, soulDrop + 10);
        player.TakeSoul(soulDrop);
        player.TakeExp(expDrop);
        player.TakeGold(goldDrop);
        Destroy(this.gameObject);
    }
}
