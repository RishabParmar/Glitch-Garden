using UnityEngine;

public class Attacker : MonoBehaviour
{
    float walkSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * walkSpeed);
    }

    public void SetMovementSpeed(float speed)
    {
        walkSpeed = speed;
    }
}
