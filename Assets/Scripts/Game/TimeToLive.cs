/*
Destroy the game object after a certain time
*/

using UnityEngine;

public class TimeToLive : MonoBehaviour
{
    public float timeToLive;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeToLive);
    }
}
