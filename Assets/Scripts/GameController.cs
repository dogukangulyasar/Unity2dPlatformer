using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameOver GameOverScreen;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject baby;
    private bool isHold;
    [SerializeField] private HealthBarController healthBarController;
    [SerializeField] private float nextActionTime = 1.8f;
    [SerializeField] private float period = 0.1f;
    void Start() {
        InvokeRepeating("DecreaseHealth", 1.0f, 1.0f);
    }

    void Update() {
        isHold = GrabController.isHold;

        if (Time.time > nextActionTime) {
            nextActionTime += period;
            if (!isHold) {
                DecreaseHealth();
            }else {
                IncreaseHealth();
            }
        }

        if (player.transform.position.y < -1f || baby.transform.position.y < -1f) {
            GameOver();
        }    
    }

    private void DecreaseHealth() {
        healthBarController.currentHealth -= 0.2f;
    }

    private void IncreaseHealth() {
        healthBarController.currentHealth -= 0.1f;
    }

    public void GameOver() {
        GameOverScreen.Setup();
    }

}
