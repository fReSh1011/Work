using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeAttack : MonoBehaviour
{
    public float offset;
    public GameObject bullet;
    public Transform shotPoint;

    private float timeBtwShots;
    public float StartBtwShots;

    public StatsPlayer mana;



    void LateUpdate()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0) && mana.manaNow >= 0 + mana.manacost)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().SetTrigger("isAttack");
                GameObject.FindGameObjectWithTag("SoundManeger").GetComponent<SoundManegerGame>().PlaySound(0);
                mana.DealingDamage();
                Instantiate(bullet, shotPoint.position, transform.rotation);
                timeBtwShots = StartBtwShots;
            }
        }
        else
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().SetTrigger("isNoAttack");
            timeBtwShots -= Time.deltaTime;
        }
    }
}
