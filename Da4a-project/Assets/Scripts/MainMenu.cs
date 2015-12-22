using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public string gameScene;
    
    public void PlayGame() {

        Application.LoadLevel(gameScene);
    }

    public void QuitGame() {

        Application.Quit();
    }
}
