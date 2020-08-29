using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 70;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        health -= collision.gameObject.GetComponent<Projectile>().GetDamageToBeDone();
        Destroy(collision.gameObject);
        Debug.Log("Health: " + health);
        if(health <=0 )
        {
            Destroy(gameObject);
        }
    }

}
