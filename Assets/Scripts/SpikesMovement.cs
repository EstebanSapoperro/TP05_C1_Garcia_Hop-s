using UnityEngine;
using UnityEngine.InputSystem;

public class SpikesMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] private float velocity;
    [SerializeField] private float limits;

    private void Start()
    {
        velocity = DataGameManager.actualSpikeSpeed;
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
