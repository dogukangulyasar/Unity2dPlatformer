using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void PlayGame() {
        SceneManager.LoadScene("MainScene");
    }
    public void About() {
        SceneManager.LoadScene("AboutScene");
    }

    public void GoBack() {
        SceneManager.LoadScene("MainMenu");
    }

    public void Help() {
        SceneManager.LoadScene("HelpScene");
    }
}
