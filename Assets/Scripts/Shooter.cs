using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;   
    // Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        // How you can change the animator
        // animator = GetComponent<Animator>();
        // animator.SetBool("IsAttacking", true);
    }    

    public void fireProjectile()
    {
        Instantiate(projectile, new Vector2(transform.position.x + 0.7f, transform.position.y), Quaternion.identity);        
    }   
}
