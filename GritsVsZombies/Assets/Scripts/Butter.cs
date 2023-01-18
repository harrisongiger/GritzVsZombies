using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Butter : MonoBehaviour
{

    public GameObject butter;
    public TMP_Text butterText;

    private bool running = false;

    private ButterCont butterCont;
    
    void Start() {
        butterCont = GetComponent<ButterCont>();
        butterText = GetComponent<TMP_Text>();
    }

    void Update(){
        if (!running) {
            StartCoroutine(Loop());
        }

        //butterText.SetText("Butter:" + ButterCont.numButter);
    }

    IEnumerator Loop() {
        running = true;

        yield return new WaitForSeconds(Random.Range(2f, 5f));
        Instantiate(butter, new Vector3(Random.Range(0f, 10f), Random.Range(0f, 10f), 0), Quaternion.identity);

        running = false;
    }
}
