using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] GameObject defender;
    private void OnMouseDown()
    {
        var defenderButtons = FindObjectsOfType<DefenderButton>();
        // For just highlighting a single object, first apply the alpha to all the defender buttons
        // And then change the alpha of the pressed buttons
        foreach(DefenderButton button in defenderButtons)
        {
            // The Color32 values are taken from the inspector(r, g, b, a) from the default faded sprites 
            // of the defender buttons
            button.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 103);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        // When you place the defender in the core game area after clicking a defender button, the
        // following method will be called
        FindObjectOfType<DefenderSpawner>().GetGameObjectBasedOnSpriteClicked(defender);
    }
}
