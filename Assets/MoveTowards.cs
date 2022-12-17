using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{

    public GameObject target;
    public float speed = 0.1f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (this.target != null)
        {
            this.transform.position = Vector2.MoveTowards(
                this.transform.position,
                this.target.transform.position,
                this.speed
            );
        }
    }
}
