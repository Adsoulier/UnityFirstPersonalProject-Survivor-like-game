using UnityEngine;

public class ProjectilePlayer : MonoBehaviour
{
    public float speed = 15.0f;
    private float yBoundaries = 8.5f;
    private float xBoundaries = 12.6f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * speed * Time.deltaTime);
        if(Mathf.Abs(transform.position.x) >= xBoundaries ||
         Mathf.Abs(transform.position.y) >= yBoundaries)
        {
            Destroy(gameObject);
        }
    }

}
