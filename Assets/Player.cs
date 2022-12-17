using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        // GameObject player = GameObject.Find("Player");
        // GameObject go = this.gameObject;
        // Access player's transform
        // this.transform = go.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Move on arrow key press
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position = new Vector2(
                this.transform.position.x + 0.1f, this.transform.position.y
            );
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position = new Vector2(
                this.transform.position.x - 0.1f, this.transform.position.y
            );
        } else if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position = new Vector2(
                this.transform.position.x, this.transform.position.y + 0.1f
            );
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position = new Vector2(
                this.transform.position.x, this.transform.position.y - 0.1f
            );
        }
    }

}