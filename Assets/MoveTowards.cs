using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{

    public GameObject target;
    public float speed = 0.1f;
    public float detectionRange = 1;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        var torches = FindObjectsOfType<Torch>();
        foreach (var torch in torches)
        {
            if (torch.getRadius() > Vector2.Distance(this.transform.position, torch.transform.position))
            {
                this.target = torch.gameObject;
                this.transform.position = Vector2.MoveTowards(
                    this.transform.position,
                    this.target.transform.position,
                    -this.speed
                );
            }
        }

        var targetWithinRange = Vector2.Distance(
            this.transform.position, 
            this.target.transform.position
        ) < this.detectionRange;
        if (this.target != null && targetWithinRange)
        {
            this.transform.position = Vector2.MoveTowards(
                this.transform.position,
                this.target.transform.position,
                this.speed
            );
        }
    }
}
