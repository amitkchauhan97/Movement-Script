using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Range(0,15f)]
    public float moveSpeed = 10f;

    [Range(0,10f)]
    public float jumpSpeed = 5f;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        if (rb == null)
            rb = gameObject.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Forward-Backward
        transform.Translate(0, 0, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);

        //Left-Right
        transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime ,0,0);

        //Jump
        if (Input.GetKey(KeyCode.Space))
            transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime);
    }
}