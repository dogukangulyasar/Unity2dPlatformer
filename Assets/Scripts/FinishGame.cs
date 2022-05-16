using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    private bool isBabyFinish = false;
    private bool isCartFinish = false;
    [SerializeField] GameOver gameOverScreen;

    void Update() {
        if(isBabyFinish && isCartFinish) {
            SceneManager.LoadScene("MainMenu");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Baby") {
            isBabyFinish = true;
        }

        if(collision.gameObject.tag == "Cart") {
            isCartFinish = true;
        }
    }
}
