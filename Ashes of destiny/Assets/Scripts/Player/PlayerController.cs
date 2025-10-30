using UnityEngine;
using static UnityEngine.InputSystem.InputAction;
public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerInputs inputs;
    [SerializeField] PlayerMovement movement;

    private void Start()
    {
        inputs.Jump.started += Saltar;
        inputs.Sprint.started += SprintPlayer;
        inputs.Sprint.canceled += NoSprintPlayer;
    }

    public void Saltar(CallbackContext context)
    {
        Debug.Log("Boton presionado");
        movement.JumpPlayer();
    }

    public void SprintPlayer(CallbackContext context)
    {
        movement.CanSprint = true;
    }

    public void NoSprintPlayer(CallbackContext context)
    {
        movement.CanSprint = false;
    }

    private void FixedUpdate()
    {
        movement.Movement(inputs.Direction);
    }
}
