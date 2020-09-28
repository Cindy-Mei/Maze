using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
    // Start is called before the first frame update
    // float speed = 0.02f;
    public CharacterController controller;

    public float speed = 12f;
    // Update is called once per frame
    void Update()
    {
        /* if (Input.GetKey(KeyCode.W))
              transform.position += Vector3.down * speed;
          if (Input.GetKey(KeyCode.S))
              transform.position += Vector3.up * speed;
          if (Input.GetKey(KeyCode.A))
              transform.position += Vector3.left * speed;
          if (Input.GetKey(KeyCode.D))
              transform.position += Vector3.right * speed;
              */
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }
}
