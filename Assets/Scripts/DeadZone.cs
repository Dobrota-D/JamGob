using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private Vector3 _startPosition;

    private Quaternion _startRotation;

    private Rigidbody _rigideBody;

    void Start()
    {
        _startPosition = transform.position;
        _startRotation = transform.rotation;
        _rigideBody = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            other.transform.position = _startPosition;
            other.transform.rotation = _startRotation;
            _rigideBody.velocity = Vector3.zero;
            _rigideBody.angularVelocity = Vector3.zero;
        }
    }
}
