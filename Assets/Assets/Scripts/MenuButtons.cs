using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuButtons : MonoBehaviour
{
    public int level;
    public void _LoadScene()
    {
        SceneManager.LoadScene("Level_" + level.ToString());
    }
    public void _StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void _RestartLevel()
    {
        SceneManager.LoadScene(sceneBuildIndex: SceneManager.GetActiveScene().buildIndex);
    }
    public void _BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void _ExitGame()
    {
        Application.Quit();

    }
    public AudioSource AudioPlay;
    public void PlaySound()
    {
        AudioPlay.Play();
    }
}
