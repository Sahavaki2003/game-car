using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public GameObject Car;
    Vector3 offset;
    void Start()
    {
        offset = transform.position - Car.transform.position;
    }
    private void LateUpdate()
    {
        transform.position = Car.transform.position + offset;
    }
}
