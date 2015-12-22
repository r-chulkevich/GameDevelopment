using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    public string gameScene;
    public GameObject pauseMenu;
    public GameObject pauseButton;

    public void PauseGame() {

        pauseButton.SetActive(false);
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void ResumeGame() {

        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void QuitToMainMenu() {

        Time.timeScale = 1f;
        Application.LoadLevel(gameScene);
    }
}
