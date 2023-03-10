using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    public GameObject rat;

    private int x;
    private int y;

    private int waitTime;

    private int[] waveNums;
    private int waveCount;
    private int waveNum;

    private bool running = false;

    // Start is called before the first frame update
    void Start() {
        waitTime = 3;
        waveNum = 0;
        waveCount = 0;

        waveNums = new int[] {1, 4, 5};
    }

    // Update is called once per frame
    void Update() {
        if (!running) {
            if (waveCount <= waveNums[waveNum]) {
                StartCoroutine(Loop());
                waitTime = 3;
            }
            else {
                waitTime = 10;
                waveNum += 1;
                waveCount = 0;
            }
        }
    }

    IEnumerator Loop() {
        running = true;

        yield return new WaitForSeconds(waitTime);
        Instantiate(rat, new Vector3(x, y, 0), Quaternion.identity);
        waveCount += 1;

        running = false;
    }
}
