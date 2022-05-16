using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameOver GameOverScreen;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject baby;
    [SerializeField] private GameObject cart;
    public static float decreaseValue = 0.2f;
    public static float increaseValue = 0.1f;
    private bool isHold;
    [SerializeField] private HealthBarController healthBarController;
    [SerializeField] private float nextActionTime = 1.8f;
    [SerializeField] private float period = 0.1f;
    void Start() {
    }

    void Update() {
        isHold = GrabController.isHold;
        if (Time.time > nextActionTime) {
            nextActionTime += period;
            if (!isHold && HealthBarController.currentHealth > 0.5f) {
                DecreaseHealth();
            }else {
                IncreaseHealth();
            }
        }

        if(HealthBarController.currentHealth <= 1f) {
            GameOver();
        }

        if (player.transform.position.y < -1f || baby.transform.position.y < -1f) {
            GameOver();
        }
    }

    private void DecreaseHealth() {
        HealthBarController.currentHealth -= decreaseValue;
    }

    private void IncreaseHealth() {
        HealthBarController.currentHealth += increaseValue;
    }

    public void GameOver() {
        HealthBarController.currentHealth = 10;
        SceneManager.LoadScene("MainMenu");
    }

}

