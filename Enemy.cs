using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    private Rigidbody2D rb;
    public GameObject player;
    public GameObject gameOverMenu;
    [SerializeField]
    private GameObject redParticles;
    public Transform Portal;
    
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Instantiate(redParticles, transform.position, transform.rotation);
            Destroy(gameObject);
            ScoreManager.instance.AddPoint();   
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement player = collision.GetComponent<PlayerMovement>();
        Instantiate(player, transform.position, transform.rotation);
    }
}
