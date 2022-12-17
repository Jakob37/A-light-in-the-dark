using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Torch : MonoBehaviour
{

    public float fullDuration = 5;
    public float fullLightRadius = 6;
    private int currLightRadius = 0;
    private float currDuration = 5;

    private Light2D light2D;

    public void resetLight()
    {
        this.currDuration = this.fullDuration;
    }

    public float getRadius()
    {
        return this.light2D.pointLightOuterRadius;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.light2D = this.GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currDuration > 0)
        {
            currDuration -= Time.deltaTime;
        }

        if (currDuration > 0)
        {
            this.light2D.intensity = 1;
        }
        else
        {
            this.light2D.intensity = 0;
        }

        this.light2D.pointLightOuterRadius = this.fullLightRadius * (currDuration / fullDuration);
    }
}
