using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sPotController : MonoBehaviour
{

    public int health;

    private bool running = false;
    private bool run = false;

    // Start is called before the first frame update
    void Start() {
        health = 200;
    }

    void Update() {
        if (health <= 0) {
            Destroy(this.gameObject);
        }

        if (run) {
            if (!running) {
                StartCoroutine(Loop());
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Enemy") {
            health -= 10;
            run = true;
        }
    }

    void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Enemy") {
            run = false;
        }
    }

    IEnumerator Loop() {
        running = true;

        yield return new WaitForSeconds(1);
        health -= 10;

        running = false;
    }
}
