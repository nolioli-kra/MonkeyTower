using System;
using UnityEngine;
using UnityEngine.Events;

public class BananaBehaviour : MonoBehaviour
{
    public UnityEvent onBananaTapped;

    void Update()
    {
        // Handle touch input
        if (Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                Touch touch = Input.GetTouch(i);

                if (touch.phase == TouchPhase.Began)
                {
                    Ray ray = Camera.main.ScreenPointToRay(touch.position);
                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.collider.gameObject == gameObject)
                        {
                            Debug.Log("Banana tapped via touch!");
                            if (onBananaTapped != null)
                            {
                                onBananaTapped.Invoke();
                            }
                            
                            // Optionally, destroy the banana after it's tapped
                            // Destroy(gameObject);
                        }
                    }
                }
            }
        }

        // Handle mouse input for testing in the editor
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    Debug.Log("Banana tapped via mouse!");
                    if (onBananaTapped != null)
                    {
                        onBananaTapped.Invoke();
                    }
                    
                    // Optionally, destroy the banana after it's tapped
                    // Destroy(gameObject);
                }
            }
        }
    }
}
