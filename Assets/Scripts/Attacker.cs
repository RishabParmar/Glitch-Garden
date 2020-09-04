using System.Collections;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    float walkSpeed;
    Animator animator;
    GameObject collisionObject = null; 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * walkSpeed);
        if(collisionObject == null)
        {            
            animator.SetBool("isAttacking", false);           
        }
    }

    public void SetMovementSpeed(float speed)
    {
        walkSpeed = speed;
    }

    public void dealDamage(int damage)
    {
        if(collisionObject)
        {
            collisionObject.GetComponent<Defenders>().dealDamageToDefender(damage);
        }        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {    
        if (collision.gameObject.tag == "gravestone" && gameObject.tag == "Fox")
        {
            Debug.Log(collision.gameObject.name);
            animator.SetBool("isGravestone", true);
            StartCoroutine(SwitchToWalkingAgain());
        }
        else if (collision.gameObject.GetComponent<Defenders>() != null)
        {
            animator.SetBool("isAttacking", true);
            collisionObject = collision.gameObject;            
        }
    }

    private IEnumerator SwitchToWalkingAgain()
    {
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("isGravestone", false);
    }

    // For fox jump x movement:
    public void foxJump()
    {
        transform.position = new Vector2(transform.position.x - 0.5f, transform.position.y);
    }
}
