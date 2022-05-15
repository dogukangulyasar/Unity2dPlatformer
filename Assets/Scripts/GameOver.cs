using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    public void Restart() {
        Debug.Log("BASIYOTTY");
        SceneManager.LoadScene("MainScene");
    }

    public void Win() {
        Debug.Log("asdasd");
        SceneManager.LoadScene("MainScene");
    }

    public void Exit() {
        //Menu Scene
        Debug.Log("Menu Scene");
    }

    public void Setup() {
        gameObject.SetActive(true);
    }
}
