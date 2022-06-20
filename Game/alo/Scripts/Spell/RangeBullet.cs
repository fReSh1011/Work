using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeBullet : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;

    void Update()
    {
        lifetime -= 1;
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance);
        if (hitInfo.collider !=null && !hitInfo.collider.CompareTag("Player"))
        {
            if (hitInfo.collider.CompareTag("Enemy"))
                hitInfo.collider.GetComponent<Enemy>().TakeDamege(GameObject.FindGameObjectWithTag("Player").GetComponent<StatsPlayer>().damage);
            Destroy(gameObject);
        }

        if (lifetime <= 0)
            Destroy(gameObject);
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
