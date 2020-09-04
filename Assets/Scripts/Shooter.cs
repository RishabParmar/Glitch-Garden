using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;   

    public void fireProjectile()
    {
        Instantiate(projectile, new Vector2(transform.position.x + 0.7f, transform.position.y), Quaternion.identity);        
    }   
}
