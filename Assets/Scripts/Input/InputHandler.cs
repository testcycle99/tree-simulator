using UnityEngine;

public class InputHandler : MonoBehaviour
{
    void Update()
    {
        HandleTouchInput();
        HandleMouseInput();
    }

    private void HandleTouchInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Handle touch began
                    Debug.Log("Touch began at: " + touch.position);
                    break;
                case TouchPhase.Moved:
                    // Handle touch moved
                    break;
                case TouchPhase.Ended:
                    // Handle touch ended
                    break;
            }
        }
    }

    private void HandleMouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Handle mouse button down
            Debug.Log("Mouse button pressed at: " + Input.mousePosition);
        }
    }
}