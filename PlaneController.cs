using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float turnSpeed = 10000;

    public Transform TopRotor;
    public Transform TailRotor;

    Rigidbody Plane;
    public Vector3 UpwardForce = Vector3.zero;
   


    // Start is called before the first frame update
    void Start()
    {
        Plane = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

        TopRotor.transform.Rotate(0, turnSpeed, 0);
        TailRotor.transform.Rotate(turnSpeed, 0, 0);
    }
}
