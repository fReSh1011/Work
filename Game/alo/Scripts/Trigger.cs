using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject player;
    public int x;
    public int y;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if (!(GameObject.FindGameObjectWithTag("SpawnMob").GetComponent<SpawnMobs>().activeSpawn))
            {
                GameObject.FindGameObjectWithTag("SpawnMob").GetComponent<SpawnMobs>().activeSpawn = true;
            }
            else
            {
                GameObject.FindGameObjectWithTag("SpawnMob").GetComponent<SpawnMobs>().activeSpawn = false;
            }
            other.transform.position = new Vector2(x, y);
        }
    }
}
