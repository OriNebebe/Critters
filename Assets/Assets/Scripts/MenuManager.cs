using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenuCanvasGO;
    [SerializeField] private GameObject _settingsMenuCanvasGO;
    [SerializeField] private GameObject _creditsMenuCanvasGO;
    [SerializeField] private GameObject _arcadeMenuCanvasGO;

    private bool isPaused;
    private void Start()
    {
        _mainMenuCanvasGO.SetActive(false);
        _settingsMenuCanvasGO.SetActive(false);
        _creditsMenuCanvasGO.SetActive(false);
        _arcadeMenuCanvasGO.SetActive(false);
    }

    private void Update()
    {
        if (InputManager.instance.MenuOpenCloseInput)
        {
            if (!isPaused)
            {
                Pause();
            }
            else
            {
                Unpause();
            }
        }
    }
    #region Pause/Unpause Functions
    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;
        OpenMainMenu();
    }
    public void Unpause()
    {
        isPaused = false;
        Time.timeScale = 1f;
        CloseAllMenus();
    }

    #endregion

    #region Canvas Activations/Deactivation
    private void OpenMainMenu()
    {
        _mainMenuCanvasGO.SetActive(true);
        _settingsMenuCanvasGO.SetActive(false);
        _creditsMenuCanvasGO.SetActive(false);
        _arcadeMenuCanvasGO.SetActive(false);
    }

    private void OpenSettingsMenuHandle()
    {
        _settingsMenuCanvasGO.SetActive(true);
        _mainMenuCanvasGO.SetActive(false);
        _creditsMenuCanvasGO.SetActive(false);
        _arcadeMenuCanvasGO.SetActive(false);
    }
    private void OpenCreditsMenuHandle()
    {
        _settingsMenuCanvasGO.SetActive(false);
        _mainMenuCanvasGO.SetActive(false);
        _creditsMenuCanvasGO.SetActive(true);
        _arcadeMenuCanvasGO.SetActive(false);
    }

    private void OpenArcadeMenuHandle()
    {
        _settingsMenuCanvasGO.SetActive(false);
        _mainMenuCanvasGO.SetActive(false);
        _creditsMenuCanvasGO.SetActive(false);
        _arcadeMenuCanvasGO.SetActive(true);
    }

    private void CloseAllMenus()
    {
        _mainMenuCanvasGO.SetActive(false);
        _settingsMenuCanvasGO.SetActive(false);
        _creditsMenuCanvasGO.SetActive(false);
        _arcadeMenuCanvasGO.SetActive(false);
    }
    #endregion
    #region Main Menu Button Actions
    public void _OnOptionPress()
    {
        OpenMainMenu();
    }
    public void _OnSettingsPress()
    {
        OpenSettingsMenuHandle();
    }
    public void _OnCreditsPress()
    {
        OpenCreditsMenuHandle();
    }
    public void _OnArcadePress()
    {
        OpenArcadeMenuHandle();
    }
    #endregion

    #region Settings Menu Button Actions
    public void OnSettingsBackPress()
    {
        OpenMainMenu();
    }
    public void _ManualPause()
    {
        isPaused = true;
        Time.timeScale = 0f;
    }
    #endregion
}