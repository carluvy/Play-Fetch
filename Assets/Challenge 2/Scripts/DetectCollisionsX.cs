using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
