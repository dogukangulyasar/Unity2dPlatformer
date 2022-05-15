using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2DController : MonoBehaviour {
    [SerializeField] private float MovementSpeed = 0f;
    private Rigidbody2D _rigidbody;
    [SerializeField] float JumpForce = 1f;
    [SerializeField] private Animator _animator;


    void Start() {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update() {
        float movement = Input.GetAxis("Horizontal");
        bool isJump = Input.GetButtonDown("Jump");
        _animator.SetBool("isRun", false);

        if (movement != 0f) {
            Run(movement);
            _animator.SetBool("isRun", true);
        }

        if (isJump) {
            Jump();
        }

    }

    void Run(float movement) {
        if(movement < 0f) {
            transform.localScale = new Vector3(-0.3f, transform.localScale.y);
        } else {
            transform.localScale = new Vector3(0.3f, transform.localScale.y);
        }
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
    }

    void Jump() {
        
        if (Mathf.Abs(_rigidbody.velocity.y) < 0.001f) {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
