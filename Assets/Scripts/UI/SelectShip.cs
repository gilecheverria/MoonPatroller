/*
Store in Player Prefs the index of the ship
selected by the user

Gilberto Echeverria
19/11/2020
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectShip : MonoBehaviour
{
    public void Select(int index)
    {
        PlayerPrefs.SetInt("ShipType", index);
        SceneManager.LoadScene("Game");
    }
}