using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private LayerMask floorLayer;
    
    private bool isPressingUp = false;
    private bool isTappetUp = false;
    private bool inFloor = false;
    [SerializeField] private float jumpForce = 10;
    [SerializeField] private float originalGravityScale = 3;
    [SerializeField] private float jumpGravityScale = 1f;
    [SerializeField] private float rayCastLong = 2.2f;
    public Rigidbody2D rb;

    private void Start()
    {
        rb.gravityScale = originalGravityScale;
    }

    private void OnCollisionEnter2D(Collision2D thing)
    {
        SpikesMovement collisionedOther = thing.gameObject.GetComponent<SpikesMovement>();

        if (collisionedOther != null) 
        {
            Debug.Log("hola, se coliciono con el spike");
        }

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            isPressingUp = true;
            isTappetUp = true;
        }
        else
        {
            isPressingUp = false;
            isTappetUp = false;
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.localPosition, Vector2.down, rayCastLong, floorLayer);
        inFloor = hit.collider != null;
    }

    private void FixedUpdate()
    {
        if (isPressingUp)
        {
            rb.gravityScale = jumpGravityScale;
        }
        else 
        {
            rb.gravityScale = originalGravityScale;
        }

        if ((isTappetUp) && (inFloor)) 
        {
            rb.linearVelocityY = jumpForce;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * rayCastLong);
    }

}
