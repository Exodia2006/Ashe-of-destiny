using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    float speed;
    [SerializeField] float jumpForce;
    private bool _canSprint = false;

    public bool CanSprint { get => _canSprint; set => _canSprint = value; }

    private void OnEnable()
    {
        EventBus.GameStart += CanMovement;
    }

    private void OnDisable()
    {
        EventBus.GameStart -= CanMovement;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void CanMovement()
    {
        rb.isKinematic = false;
    }

    public void Movement(Vector2 direction)
    {
        if(_canSprint == true)
        {
            speed = 5;
        }

        else
        {
            speed = 2;
        }
            Vector3 moveDir = new Vector3(direction.x, rb.linearVelocity.y, direction.y);
        rb.linearVelocity = new Vector3(moveDir.x * speed, moveDir.y, moveDir.z * speed);
    }

    public void JumpPlayer()
    {
        Debug.Log("Hola");
        rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }
}
