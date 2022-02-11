﻿/*
Allow a game object to take several hits before being destroyed

Gil Echeverria
24/09/2020
*/

using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public Slider healthBar;

    bool display = false;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        if (healthBar != null)
        {
            healthBar.maxValue = maxHealth;
            healthBar.value = currentHealth;
            display = true;
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (display)
        {
            healthBar.value = currentHealth;
        }

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}