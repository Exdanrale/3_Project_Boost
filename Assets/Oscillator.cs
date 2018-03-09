using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour
{

    [SerializeField] Vector3 movementVector;
    [SerializeField] float movementFactor = 1f;
    [SerializeField] float movementPeriod = 2f;
    Vector3 startingPosition;

    [SerializeField] float rotationSpeed;

    // Use this for initialization
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        ManageTranslation();
        ManageRotation();
    }

    private void ManageTranslation()
    {
        if (movementPeriod <= Mathf.Epsilon) { return; }
        transform.position = startingPosition + movementVector * Mathf.PingPong(Time.time / movementPeriod, 1) * movementFactor;
    }

    private void ManageRotation()
    {
        // todo try with a sine rotation for non sequential
        //transform.Rotate(Vector3.forward * Mathf.Sin(rotationThisFrame * Time.time));
        transform.Rotate(Vector3.forward * Mathf.PingPong(Time.time, 1) * rotationSpeed);
    }
}
