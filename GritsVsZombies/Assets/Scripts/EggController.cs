using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{

    public GameObject attack;

    private int waitTime;

    private bool running = false;

    private float x;
    private float y;

    public int health;

    // Start is called before the first frame update
    void Start() {
        waitTime = 3;
        health = 100;
    }

    // Update is called once per frame
    void Update() {
        x = this.gameObject.transform.position.x;
        y = this.gameObject.transform.position.y;

        if (!running) {
            StartCoroutine(Loop());
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
        }
    }
}
