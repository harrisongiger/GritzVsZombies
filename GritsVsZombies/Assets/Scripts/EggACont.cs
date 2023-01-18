using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggACont : MonoBehaviour
{

    private float moveSpeed;

    // Start is called before the first frame update
    void Start() {
        moveSpeed = 0.01f;
    } 

    void FixedUpdate() {
        this.gameObject.transform.position = new Vector3(transform.position.x + moveSpeed, transform.position.y, transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Enemy") {
            Destroy(this.gameObject);
        }
    }
}
