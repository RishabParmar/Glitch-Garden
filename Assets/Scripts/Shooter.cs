using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fireProjectile()
    {
        Instantiate(projectile, new Vector2(transform.position.x + 0.7f, transform.position.y), Quaternion.identity);        
    }

}
