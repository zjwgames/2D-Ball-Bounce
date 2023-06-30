using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public string lastClicked;
    int forceMagnitude = 500;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
                Debug.Log("CLICKED " + hit.collider.name);
                lastClicked= hit.collider.name;
                Rigidbody2D rb = hit.collider.GetComponent<Rigidbody2D>();
                if (rb != null) rb.AddForce(Vector2.up * forceMagnitude);
            }            
        }
    }
}
