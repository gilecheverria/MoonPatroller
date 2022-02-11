/*
Orient an empty object so that the bullets fire aim towards the position
of the mouse

Gilberto Echeverria
24/09/2020
*/

using UnityEngine;

public class AimWithMouse : MonoBehaviour
{
    public Camera sceneCamera;
    public Transform spawner;

    Vector3 targetPosition;
    Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        targetPosition = sceneCamera.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = 0;
        // Trace the direction from the fire point to the mouse position
        direction = targetPosition - spawner.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        spawner.rotation = Quaternion.Euler(0, 0, angle);
    }
}