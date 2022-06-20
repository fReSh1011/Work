using UnityEngine;

public class SpawnMobs : MonoBehaviour
{
    public GameObject[] mob;
    public GameObject[] spawnPointMob;

    private float timeBtwSpawn;
    public float StartBtwSpawn;

    System.Random rnd = new System.Random();

    public bool activeSpawn = false;
    void Update()
    {
        if (timeBtwSpawn <= 0 && activeSpawn)
        {
            Instantiate(mob[0], spawnPointMob[rnd.Next(spawnPointMob.Length)].transform.position, Quaternion.identity);
            timeBtwSpawn = StartBtwSpawn;
        }
        else
            timeBtwSpawn -= Time.deltaTime;
    }
}
