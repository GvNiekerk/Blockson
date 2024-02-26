using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotationX;
    [SerializeField] float rotationY;
    [SerializeField] float rotationZ;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationX, rotationY, rotationZ);
    }
}
