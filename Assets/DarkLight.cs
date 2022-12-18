using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class DarkLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var light = this.GetComponent<Light2D>();
        light.intensity = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
