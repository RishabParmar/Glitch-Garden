using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 70;
    [SerializeField] GameObject deathVFX;   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // When the trigger happens, we should check if it is an attacker too!
        if(GetComponent<Attacker>())
        {
            health -= collision.gameObject.GetComponent<Projectile>().GetDamageToBeDone();
            Destroy(collision.gameObject);          
            if (health <= 0)
            {
                // Instantiate creates a new gameobject in the game hierarchy such that even tho Lizard gameObject is destroyed,
                // the VFX object will be under the hierarchy but not as a child of Lizard. So, it doesn't get destroyed.
                // So destroy the VFX gameObject after the VFX is done playing.
                Destroy(Instantiate(deathVFX, transform.position, Quaternion.identity), 1.5f);
                Destroy(gameObject);
            }
        }        
    }

}
