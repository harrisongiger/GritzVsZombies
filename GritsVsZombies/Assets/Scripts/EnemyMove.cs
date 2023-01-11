using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    private SpriteRenderer sprite;

    public float moveSpeed;

    // Start is called before the first frame update
    void Start() {
        sprite = GetComponent<SpriteRenderer>();
        moveSpeed = 0.01f;
    }

    void FixedUpdate() {
        this.gameObject.transform.position = new Vector3(transform.position.x + moveSpeed, transform.position.y, transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Plant") {
            moveSpeed = 0f;
        }
    }
}
