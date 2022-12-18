using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    private Torch torch;

    void Start()
    {
        this.torch = this.GetComponent<Torch>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position = new Vector2(
                this.transform.position.x + speed, this.transform.position.y
            );
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position = new Vector2(
                this.transform.position.x - speed, this.transform.position.y
            );
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position = new Vector2(
                this.transform.position.x, this.transform.position.y + speed
            );
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position = new Vector2(
                this.transform.position.x, this.transform.position.y - speed
            );
        }
    }

}