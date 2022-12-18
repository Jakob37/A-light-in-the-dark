using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{

    public GameObject target;
    public float speed = 0.1f;
    public float detectionRange = 1;

    void FixedUpdate()
    {

        var torch = this.getClosestTorchInRange();
        if (torch != null)
        {
            var torchObj = torch.gameObject;
            this.moveTowards(torchObj, -this.speed);
            torch.consume(Time.deltaTime);
        }

        if (this.getTargetInRange())
        {
            this.moveTowards(this.target, this.speed);
        } else {
            this.idleMove(this.speed);
        }
    }

    private Torch getClosestTorchInRange()
    {
        var torches = FindObjectsOfType<Torch>();
        foreach (var torch in torches)
        {
            if (torch.getRadius() > Vector2.Distance(this.transform.position, torch.transform.position))
            {
                return torch;
            }
        }
        return null;
    }

    private bool getTargetInRange()
    {
        if (this.target == null)
        {
            return false;
        }
        return Vector2.Distance(
            this.transform.position,
            this.target.transform.position
        ) < this.detectionRange;
    }

    private void moveTowards(GameObject target, float speed)
    {
        this.transform.position = Vector2.MoveTowards(
            this.transform.position,
            target.transform.position,
            speed
        );
    }

    private void idleMove(float speed)
    {
        this.transform.position = new Vector2(
            this.transform.position.x + Random.Range(-speed, speed),
            this.transform.position.y + Random.Range(-speed, speed)
        );
    }
}
