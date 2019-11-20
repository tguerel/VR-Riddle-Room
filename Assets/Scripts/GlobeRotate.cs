using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeRotate : MonoBehaviour
{

    public bool startRotation = false; 

    public void PrintX()
    {
        startRotation = true;
    }

    public void RotateGlobe()
    {
        transform.Rotate(new Vector3(10, 25, 0) * Time.deltaTime);
    }

    private void Update()
    {
        if (startRotation)
        {
            RotateGlobe();
        }
    }
}
