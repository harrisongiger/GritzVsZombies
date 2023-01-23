using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{

    public GameObject attack;

    private float waitTime;

    private bool running = false;

    private bool running2 = false;
    private bool run = false;

    private float x;
    private float y;

    public int health;

    // Start is called before the first frame update
    void Start() {
        waitTime = 2f;
        health = 100;
    }

    // Update is called once per frame
    void Update() {
        x = this.gameObject.transform.position.x;
        y = this.gameObject.transform.position.y;

        if (!running) {
            StartCoroutine(Loop());
        }

        if (run) {
            if (!running2) {
                StartCoroutine(Loop2());
            }
        }

        if (health <= 0) {
            Destroy(this.gameObject);
        }
    }

    IEnumerator Loop() {
        running = true;

        yield return new WaitForSeconds(waitTime);
        Instantiate(attack, new Vector3(x + 0.6f, y, 0), Quaternion.identity);

        running = false;
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

    IEnumerator Loop2() {
        running2 = true;

        yield return new WaitForSeconds(1);
        health -= 10;

        running2 = false;
    }
}
