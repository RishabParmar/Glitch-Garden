using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenders : MonoBehaviour
{
    [SerializeField] public int stars;
    [SerializeField] public int health;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<StarDisplayer>().StarsSpent(stars);
    }

    public void addStarsIntoStarDisplayer(int starsToBeAdded)
    {
        FindObjectOfType<StarDisplayer>().AddStars(starsToBeAdded);
    }    

    public void dealDamageToDefender(int damage)
    {
        health -= damage;      
        if(health <= 0)
        {            
            if(gameObject.name == "Cactus(Clone)")
            {               
                DefenderSpawner.grid[(int)transform.position.x, (int)(transform.position.y - 0.5f)] = 0;               
            } else
            {               
                DefenderSpawner.grid[(int)transform.position.x, (int)Math.Ceiling(transform.position.y)] = 0;                
            }
            Destroy(gameObject);
        }
    }
}
    