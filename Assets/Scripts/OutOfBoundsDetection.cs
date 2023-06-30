using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsDetection : MonoBehaviour
{
    public GameObject mainCamera;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            Destroy(coll.gameObject);
            Debug.Log("Ball out of bounds");
            if (coll.gameObject.name != mainCamera.GetComponent<Bounce>().lastClicked)
            {
                Debug.Log("YOU WIN!");
            }
        }
    }
}
