using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Torch torch;

    void Start()
    {
        this.torch = this.GetComponent<Torch>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            this.torch.resetLight();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position = new Vector2(
                this.transform.position.x + 0.1f, this.transform.position.y
            );
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position = new Vector2(
                this.transform.position.x - 0.1f, this.transform.position.y
            );
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position = new Vector2(
                this.transform.position.x, this.transform.position.y + 0.1f
            );
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position = new Vector2(
                this.transform.position.x, this.transform.position.y - 0.1f
            );
        }
    }

}