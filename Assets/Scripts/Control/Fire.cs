/*
Fire projectiles from the set origin
*/

using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawn;
    public float delay;

    float nextShot = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > nextShot)
            {
                Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
                nextShot = Time.time + delay;
            }
        }    
    }
}