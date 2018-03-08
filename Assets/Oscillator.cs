using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour
{

    Vector3 movementVector = new Vector3(0, 15, 0);
    float movementFactor;
    Vector3 startingPosition;

    // Use this for initialization
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startingPosition + movementVector * Mathf.PingPong(Time.time / 2, 1);
    }
}
