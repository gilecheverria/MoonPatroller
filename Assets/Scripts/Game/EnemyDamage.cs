/*
Allow an enemy to damage the player

Gil Echeverria
24/09/2020
*/

using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
    }
}