using UnityEngine;

public class MouseMove : MonoBehaviour
{
    void Update()
    {
        // Get the current mouse position
        Vector3 mousePos = Input.mousePosition;
        
        // Convert the mouse position from screen space to world space
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        
        // Set the position of the gameobject to the mouse position
        this.gameObject.transform.position = new Vector3(worldPos.x, worldPos.y, 0);
    }
}