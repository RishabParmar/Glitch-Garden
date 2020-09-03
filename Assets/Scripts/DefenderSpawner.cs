using System;
using UnityEngine;

// ******************* INSTEAD OF DOING THE CALCULATION BELOW (My solution, line 20), WE CAN ALSO USE Mathf.RoundToInt() for snapping
// objects to play grid
public class DefenderSpawner : MonoBehaviour
{    
    GameObject defender;
    int starRequirementForDependerSpawn;
    // The 
    static public int[,] grid = new int[7, 5];
    // OnMouseDown() works when the player clicks over the collider or GUIElement that is attached to the gameObject

    private void OnMouseDown()
    {        
        // If the defender has not been clicked from the defender buttons, then clicking on the core game will say that
        // the object is null. Therefore, only perform the following operations when defender is not null.
        // At the same time check if the defender is clickable when the player has enough stars.        
        if (defender != null)
        {
            int gridXPos = -1;
            int gridYPos = -1;
            starRequirementForDependerSpawn = defender.GetComponent<Defenders>().stars;
            if (FindObjectOfType<StarDisplayer>().ReturnStars() >= starRequirementForDependerSpawn)
            {
                // Rotating the Cactus defender around 180 as to face towards the right side
                Vector2 placeClicked = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                // X Grid Snapping
                if (placeClicked.x <= 0)
                {
                    placeClicked.x = 0f;
                    gridXPos = (int)placeClicked.x;
                }
                else
                {
                    placeClicked.x = (placeClicked.x % 1) < 0.5f ? (float)Math.Floor(placeClicked.x) : (float)Math.Ceiling(placeClicked.x);
                    gridXPos = (int)placeClicked.x;
                }
                // Y Grid Snapping
                if (placeClicked.y <= 0)
                {
                    if (defender.name == "Cactus")
                    {
                        placeClicked.y = 0.5f;
                        gridYPos = (int)(placeClicked.y - 0.5f);
                    }
                    else
                    {                        
                        placeClicked.y = 0f;
                        gridYPos = (int)placeClicked.y;
                    }
                }
                else
                {
                    placeClicked.y = (placeClicked.y % 1) > 0.5f ? (float)Math.Ceiling(placeClicked.y) : (float)Math.Floor(placeClicked.y);
                    gridYPos = (int)placeClicked.y;
                    // Cactus's offset is a little off, hence adding some offset to the y co-ordinate
                    if (defender.name == "Cactus")
                    {
                        gridYPos = (int)(placeClicked.y);
                        placeClicked.y += 0.5f;                        
                    }
                }             
                if (grid[gridXPos, gridYPos] == 0)
                {
                    if(defender.name == "Gravestone")
                    {
                        Instantiate(defender, placeClicked, Quaternion.Euler(0f, 0f, 0f));
                    } else
                    {
                        Instantiate(defender, placeClicked, Quaternion.Euler(0f, 180f, 0f));
                    }
                    
                    grid[gridXPos, gridYPos] = 1;                 
                }                
            }
        }        
    }

    public void GetGameObjectBasedOnSpriteClicked(GameObject selectedDefender)
    {
        defender = selectedDefender;
    }
}
