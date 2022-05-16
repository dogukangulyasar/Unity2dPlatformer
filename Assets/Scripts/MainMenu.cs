using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    [SerializeField] private TextMesh buttonText;
    public static int i = 0;
    public void PlayGame() {
        HealthBarController.currentHealth = 10;
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

    public void SetEasy() {
        GameController.decreaseValue = 1.0f;
    }

    public void SetMedium() {
        GameController.decreaseValue = 1.5f;
    }

    public void SetHard() {
        GameController.decreaseValue = 2.0f;
    }
}
