using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEsc : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void IralMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
