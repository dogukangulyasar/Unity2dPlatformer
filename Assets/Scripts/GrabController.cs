using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabController : MonoBehaviour {

    [SerializeField] private Transform grabDetect;
    [SerializeField] private Transform babyHolder;
    [SerializeField] private float rayDist;
    public static bool isHold;

    // Update is called once per frame
    void Update() {
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);

        if(grabCheck.collider != null && grabCheck.collider.tag == "Baby" ||
           grabCheck.collider != null && grabCheck.collider.tag == "Guns") {
            if(Input.GetKey(KeyCode.Mouse0)) {
                grabCheck.collider.gameObject.transform.parent = babyHolder;
                grabCheck.collider.gameObject.transform.position = babyHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
                isHold = true;
            }else {
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
                isHold =false;
            }
        }
    }
}
