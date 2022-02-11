/*
Detect when the player touches the coin

Gil Echeverria
14/09/2020
*/

using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        print("COLLIDED WITH " + col.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        print("TRIGGERED BY " + col.gameObject.name);
    }
}
