using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPortal : MonoBehaviour
{
    private Rigidbody2D rb;
    public int car;
    public float speed;
    public GameObject enemyPrefab;
    public Transform rp;
    public Transform lp;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(car*speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.A))
        {
            car = 1;
            Instantiate(enemyPrefab, lp.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            car= -1;
            Instantiate(enemyPrefab, rp.position, transform.rotation);
        }
    }
}
