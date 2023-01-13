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

    // Start is called before the first frame update
    void Start() {
        waitTime = 3;
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
        Instantiate(attack, new Vector3(x, y, 0), Quaternion.identity);

        running = false;
    }
}
