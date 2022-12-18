using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class DarkCreature : MonoBehaviour
{

    public Health health;
    public int size;
    private DarkCreature creature;
    private SpriteRenderer sprite;

    private bool consumed;

    // Start is called before the first frame update
    void Start()
    {
        var light = this.GetComponent<Light2D>();
        light.intensity = -1;

        this.health = this.GetComponent<Health>();
        this.size = 1;
        this.creature = this.GetComponent<DarkCreature>();
        this.sprite = this.GetComponent<SpriteRenderer>();
        this.consumed = false;
    }

    void Update()
    {
        // this.sprite.size = new Vector2(this.size, this.size);
        float scaler = 0.9f + 0.1f * this.size;
        this.transform.localScale = new Vector3(scaler, scaler, 1);
    }

    private void MergeCreatures(DarkCreature other)
    {
        this.size += other.size;
        this.health.maxHealth += other.health.maxHealth;
        this.health.currHealth += other.health.currHealth;
        other.consumed = true;
        Destroy(other.gameObject);
    }

    // Collision detection
    void OnTriggerEnter2D(Collider2D other)
    {
        print(other.gameObject.tag);


        if (other.gameObject.tag == "Fire")
        {
            var torch = other.gameObject.GetComponent<Torch>();
            if (torch.getRadius() > 0)
            {
                this.health.takeDamage(1);
            }
        }

        if (other.gameObject.tag == "DarkCreature")
        {
            print("Collding with creature (trigger)");
            var creature = other.gameObject.GetComponent<DarkCreature>();
            this.MergeCreatures(creature);
        }
    }

    // Collision
    void OnCollisionEnter2D(Collision2D other)
    {
        print(other);
        // if (other.gameObject.tag == "Fire")
        // {
        //     var torch = other.gameObject.GetComponent<Torch>();
        //     if (torch.getRadius() > 0)
        //     {
        //         this.health.takeDamage(1);
        //     }
        // }


        if (other.gameObject.tag == "DarkCreature")
        {
            print("Collding with creature (collision)");
            if (!this.consumed)
            {
                var creature = other.gameObject.GetComponent<DarkCreature>();
                this.MergeCreatures(creature);
            }
        }
    }
}
