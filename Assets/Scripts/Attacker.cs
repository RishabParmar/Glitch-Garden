using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] float walkSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * walkSpeed);
    }
}
