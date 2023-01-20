using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    private SpriteRenderer sprite;

    public float moveSpeed;

    private int health;

    // Start is called before the first frame update
    void Start() {
        sprite = GetComponent<SpriteRenderer>();
        moveSpeed = 0.01f;
        health = 100;
    }

    void FixedUpdate() {
        this.gameObject.transform.position = new Vector3(transform.position.x + moveSpeed, transform.position.y, transform.position.z);
    }

    void Update() {
        if (health <= 0) {
            Destroy(this.gameObject);
            Debug.Log("DEAD");
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Plant") {
            moveSpeed = 0f;
        }
        else if (other.gameObject.tag == "PlantAtt") {
            health -= 25;
        }
    }
}
