using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterCont : MonoBehaviour
{

    public int numButter;

    void OnMouseDown() {
        Destroy(this.gameObject);
        numButter += 1;
    }
}
