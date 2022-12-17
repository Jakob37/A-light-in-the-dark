using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float maxHealth = 100;
    private float currHealth;

    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
    }

    void Update()
    {
        int torchDamage = 10;

        var torches = FindObjectsOfType<Torch>();
        // print("Found torches", torches);
        // print hello world
        // log hello

        foreach (var torch in torches)
        {
            if (torch.getRadius() > Vector2.Distance(this.transform.position, torch.transform.position))
            {
                print("Taking damage");
                takeDamage(torchDamage * Time.deltaTime);
            }
        }
    }

    public void takeDamage(float damage)
    {
        currHealth -= damage;
        print("Current health: " + currHealth);
        if (currHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
