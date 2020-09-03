using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int damageToBeDone;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * 5f);
    }

    public int GetDamageToBeDone()
    {        
        return damageToBeDone;
    }
}
