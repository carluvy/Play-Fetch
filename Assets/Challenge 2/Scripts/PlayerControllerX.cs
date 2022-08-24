using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float VerticalInput;
    public float speed = 40.0f;
    private float sendTime = 0.0f;

   
    // Update is called once per frame
    void Update()
    {
        VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * VerticalInput * Time.deltaTime * speed);
        SendDog();
        

    }

       // On spacebar press, send dog
    public void SendDog() {
        
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > sendTime) {
            sendTime = Time.time + 2.0f;

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            
            }
       }
}

