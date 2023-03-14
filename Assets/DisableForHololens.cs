//Copyright 2023 Yerio Janssen
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableForHololens : MonoBehaviour
{

#if UNITY_WSA //change this if you need to disable the object for any other platform
    void Start() //this script disables the object for any application build on the Universal Windows Platform
    {
        gameObject.SetActive(false);
    }
#endif

}
