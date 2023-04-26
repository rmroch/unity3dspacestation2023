using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinSpaceStation : MonoBehaviour
{
    public float rotationSpeed = 2f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0f, rotationSpeed, 0f, Space.Self);
    }
}
