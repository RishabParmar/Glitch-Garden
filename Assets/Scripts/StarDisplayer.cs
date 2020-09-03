using TMPro;
using UnityEngine;

public class StarDisplayer : MonoBehaviour
{    
    TextMeshProUGUI starText;
    int stars = 10000;
    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<TextMeshProUGUI>();
        starText.text = stars.ToString();        
    }
    
    public void UpdateStarText()
    {        
        starText.text = stars.ToString();       
    }

    public void AddStars(int starsToBeAdded)
    {
        stars += starsToBeAdded;
        UpdateStarText();
    }

    public void StarsSpent(int starsSpent)
    {        
        stars -= starsSpent;      
        UpdateStarText();
    }

    public int ReturnStars()
    {
        return stars;
    }

}
