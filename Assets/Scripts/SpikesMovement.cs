using UnityEngine;
using UnityEngine.InputSystem;

public class SpikesMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] float baseVelocity = 10;
    [SerializeField] float velocity;
    [SerializeField] float limits;

    void Start()
    {
        velocity = baseVelocity;
        rb.linearVelocityX = velocity;
    }

    private void FixedUpdate()
    {
        if (transform.localPosition.x < limits) 
        { 
            rb.linearVelocityX = 0;
        }
    }

}
