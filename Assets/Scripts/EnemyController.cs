using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D enemyRb;
    private Transform playerTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerTransform = GameObject.Find("Player").transform;
        enemyRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveToPlayer();
        
    }

    private void MoveToPlayer()
    {
        Vector3 direction = (playerTransform.position - transform.position).normalized;
        enemyRb.linearVelocity = direction * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Projectile_Player"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
