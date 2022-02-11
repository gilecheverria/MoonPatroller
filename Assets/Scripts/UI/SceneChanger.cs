/*
Change scenes in the game

Gilberto Echeverria
31/08/2020
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GoToScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
