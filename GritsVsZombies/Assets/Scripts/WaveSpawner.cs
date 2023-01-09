using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    public GameObject rat;

    private int x;
    private int y;

    private int waitTime;

    private bool running;

    // Start is called before the first frame update
    void Start() {
        Instantiate(rat, new Vector3(x, y, 0), Quaternion.identity);
        waitTime = 3;
    }

    // Update is called once per frame
    void Update() {
        if (!running) {
            StartCoroutine(Loop());
        }
    }

    IEnumerator Loop() {
        running = true;

        yield return new WaitForSeconds(waitTime);
        Instantiate(rat, new Vector3(x, y, 0), Quaternion.identity);

        running = false;
    }
}
