using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private LayerMask floorLayer;
    [SerializeField] private PlayerDataSo data;
    [SerializeField] private Animator animator;


    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject scorePanel;

    private bool isPressingUp = false;
    private bool isPressingDown = false;
    private bool isTappetUp = false;
    private bool inFloor = false;
    private float jumpForce;
    private float originalGravityScale;
    private float jumpGravityScale;
    private float rayCastLong;
    public Rigidbody2D rb;

    private void Start()
    {
        jumpForce = data.jumpForce;
        originalGravityScale = data.originalGravityScale;
        jumpGravityScale = data.jumpGravityScale;
        rayCastLong = data.rayCastLong;

        rb.gravityScale = originalGravityScale;
    }

    private void OnCollisionEnter2D(Collision2D thing)
    {
        SpikesMovement collisionedOther = thing.gameObject.GetComponent<SpikesMovement>();

        if (collisionedOther != null) 
        {
            DataGameManager.isFinished = true;
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            scorePanel.SetActive(false);
        }

    }

    private void Update()
    {
        if (Input.GetKey(data.jumpKey))
        {
            isPressingUp = true;
            isTappetUp = true;
        }
        else
        {
            isPressingUp = false;
            isTappetUp = false;
        }

        if (Input.GetKey(data.downKey))
        {
            isPressingDown = true;
        }
        else 
        {
            isPressingDown = false;
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.localPosition, Vector2.down, rayCastLong, floorLayer);
        inFloor = hit.collider != null;
        animator.SetBool("IsInGround", inFloor);
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

        if ((isPressingDown)) 
        {
            rb.linearVelocityY = data.downForce;
        }
    }

}
