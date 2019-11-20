using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedScript : MonoBehaviour
{
    public GameObject globe;

    private void OnCollisionEnter(Collision collision)
    {
        print("collided");

        globe.gameObject.GetComponent<GlobeRotate>().PrintX();

    }

   

}

