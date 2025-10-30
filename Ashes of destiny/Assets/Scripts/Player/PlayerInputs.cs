using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    [SerializeField] InputActionAsset actions;
    public InputAction Jump;
    public InputAction Move;
    public InputAction Sprint;
    public Vector2 Direction;

    private void Awake()
    {
        Move = actions.FindAction("Move");
        Jump = actions.FindAction("Jump");
        Sprint = actions.FindAction("Sprint");
    }
    private void Update()
    {
        Direction = Move.ReadValue<Vector2>();
    }
}
