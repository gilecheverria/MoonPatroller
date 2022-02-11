/*
Allow a bullet to reduce the HP on another object

*/

using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int damage;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            col.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
