using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Butter : MonoBehaviour
{

    public GameObject butter;
    public Text butterText;

    private bool running = false;

    public static int numButter;

    void Update(){
        if (!running) {
            StartCoroutine(Loop());
        }

        butterText.text = "Butter: " + numButter;
    }

    IEnumerator Loop() {
        running = true;

        yield return new WaitForSeconds(Random.Range(2f, 5f));
        Instantiate(butter, new Vector3(Random.Range(0f, 10f), Random.Range(0f, 10f), 0), Quaternion.identity);

        running = false;
    }
}
