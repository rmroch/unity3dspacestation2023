using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitAndDestroy : MonoBehaviour
{
    public float delay = 2.0f;

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, delay);
    }
}
