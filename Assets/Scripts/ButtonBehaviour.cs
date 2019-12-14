using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour {
    public void PlayGame() {
        SceneManager.LoadScene("StoryScene");
    }

    public void QuitGame() {
        Debug.Log("Game Quit");
        Application.Quit();
    }

    public void Continue() {
        SceneManager.LoadScene("MainGame");
    }

    public void Death() {
            SceneManager.LoadScene("DeathScreen");
    }

    public void MainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
}
