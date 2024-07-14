using UnityEngine;

public class ManualRotate : MonoBehaviour
{
    private bool isRotating = false;
    private Vector3 lastMousePosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isRotating = true;
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isRotating = false;
        }

  
        if (isRotating)
        {
            Vector3 currentMousePosition = Input.mousePosition;
            Vector3 mouseDelta = currentMousePosition - lastMousePosition;

   
            transform.Rotate(Vector3.up, -mouseDelta.x, Space.World);
            transform.Rotate(Vector3.right, mouseDelta.y, Space.World);

            lastMousePosition = currentMousePosition;
        }
    }
}

