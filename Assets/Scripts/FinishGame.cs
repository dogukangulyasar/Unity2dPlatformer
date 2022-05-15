using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    private bool isBabyFinish = false;
    private bool isGunsFinish = false;
    [SerializeField] GameOver gameOverScreen;

    void Update() {
        if(isBabyFinish && isGunsFinish) {
            Debug.Log("asdasdasdasda");
            gameOverScreen.Win();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Baby") {
            Debug.Log("baby");
            isBabyFinish = true;
        }

        if (collision.gameObject.tag == "Guns") {
            Debug.Log("gn");
            isGunsFinish = true;
        }
    }
}
