using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {
        Flip();
    }

    private void Flip()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Rotate(0,180,0);
        }
    }
}