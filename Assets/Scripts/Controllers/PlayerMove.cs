using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("Horinztonal Input Axis")]
    [Tooltip("The Axis at which the Player moves horizontally (in this case A & D)")]
    [SerializeField] private string horizontalInputName;
    [Header("Vertical Input Axis")]
    [Tooltip("The Axis at which the Player moves vertically (in this case W & S)")]
    [SerializeField] private string verticalInputName;
    [Header("Movement Speed")]
    [Tooltip("The Speed at which the Player is moving on all Axis")]
    [SerializeField] private float mvS;

    [Header("Slope Data")]
    [SerializeField] private float slopeForce;
    [SerializeField] private float slopeForceRayLength;

    private CharacterController charController;

    //[SerializeField] private AnimationCurve jumpFallOff;
    //[SerializeField] private float jumpMultiplier;


    //private bool isJumping;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float horizInput = Input.GetAxis(horizontalInputName);
        float vertInput = Input.GetAxis(verticalInputName);

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;


        charController.SimpleMove(Vector3.ClampMagnitude(forwardMovement + rightMovement, 1.0f) * mvS);

        if ((vertInput != 0 || horizInput != 0) && OnSlope())
            charController.Move(Vector3.down * charController.height / 2 * slopeForce * Time.deltaTime);

        //JumpInput();
    }

    private bool OnSlope()
    {
        //if (isJumping)
            //return false;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, charController.height / 2 * slopeForceRayLength))
            if (hit.normal != Vector3.up)
                return true;
        return false;
    }

    /*
    private void JumpInput()
    {
        if (Input.GetButton("Jump") && !isJumping)
        {
            isJumping = true;
            StartCoroutine(JumpEvent());
        }
    }
    */

    /*
    private IEnumerator JumpEvent()
    {
        charController.slopeLimit = 90.0f;
        float timeInAir = 0.0f;
        do
        {
            float jumpForce = jumpFallOff.Evaluate(timeInAir);
            charController.Move(Vector3.up * jumpForce * jumpMultiplier * Time.deltaTime);
            timeInAir += Time.deltaTime;
            yield return null;
        } while (!charController.isGrounded && charController.collisionFlags != CollisionFlags.Above);

        charController.slopeLimit = 45.0f;
        isJumping = false;
    }
    */

}