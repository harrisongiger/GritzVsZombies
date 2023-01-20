using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterCont : MonoBehaviour
{
    void OnMouseDown() {
        Destroy(this.gameObject);
        Butter.numButter += 1;
    }
}
