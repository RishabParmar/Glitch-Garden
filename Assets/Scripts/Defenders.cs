using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenders : MonoBehaviour
{
    [SerializeField] public int stars;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<StarDisplayer>().StarsSpent(stars);
    }

    public void addStarsIntoStarDisplayer(int starsToBeAdded)
    {
        FindObjectOfType<StarDisplayer>().AddStars(starsToBeAdded);
    }
}
