using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public GameObject selectedFood;

    void Update() {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

            if (targetObject) {
                selectedFood = targetObject.transform.gameObject;
            }
        }

        if (Input.GetMouseButtonUp(0) && selectedFood) {
            selectedFood = null;
        }
    }

}
