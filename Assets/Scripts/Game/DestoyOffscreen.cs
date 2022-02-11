/*
Destroy any object that goes outide of the trigger
Approximately when leaving the screen
*/

using UnityEngine;

public class DestoyOffscreen : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Bullet")
        {
            Destroy(col.gameObject);
        }
    }
}
