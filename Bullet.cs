using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    [SerializeField]
    private GameObject greenParticles;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right*speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.TakeDamage(20);
            Instantiate(greenParticles, transform.position, transform.rotation);
        }
        Instantiate(greenParticles, transform.position, transform.rotation);
        Destroy(gameObject);
    }

  
}
