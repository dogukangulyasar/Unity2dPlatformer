using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour {
    [SerializeField] private Image fillImage;
    private Slider slider;
    public float currentHealth = 10;
    [SerializeField] private float maxHealth = 10;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update() {
        float fillValue = currentHealth / maxHealth;
        slider.value = fillValue;
    }
}
