using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Torch : MonoBehaviour
{

    public float fullDuration = 5;
    public float fullLightRadius = 6;
    private float currDuration;

    private Light2D light2D;

    public void lit()
    {
        this.currDuration = this.fullDuration;
    }

    public float getRadius()
    {
        return this.light2D.pointLightOuterRadius;
    }

    public void consume(float amount)
    {
        this.currDuration -= amount;
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

    // Collision detection
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fire")
        {
            // var torch = other.gameObject.GetComponent<Torch>();
            this.lit();
        }
    }
}
