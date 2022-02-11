/*
Movement script for the bullets

Gil Echeverria
21/09/2020
*/
using UnityEngine;

public class MoveStraight : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
}