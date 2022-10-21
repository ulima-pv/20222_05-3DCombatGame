using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CuboController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 6f;

    private InputSystemCubo mInputSystem;
    private InputAction mInputActionMoverse;
    private InputAction mInputActionSaltar;
    private Rigidbody mRb;
    private Animator mAnimator;

    private void Awake()
    {
        mInputSystem = new InputSystemCubo();
        mInputActionMoverse = mInputSystem.Player.Moverse;
        mInputActionSaltar = mInputSystem.Player.Saltar;
        mInputActionSaltar.performed += DoSaltar;

        mRb = GetComponent<Rigidbody>();
        mAnimator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        mInputActionMoverse.Enable();
        mInputActionSaltar.Enable();

    }

    private void OnDisable()
    {
        mInputActionMoverse.Disable();
        mInputActionSaltar.Disable();
    }

    private void FixedUpdate()
    {
        Vector2 movement = mInputActionMoverse.ReadValue<Vector2>();

        if (movement.x != 0f || movement.y != 0f)
        {
            mAnimator.SetTrigger("Caminar");
        }else
        {
            mAnimator.SetTrigger("Parar");
        }


        transform.position +=
            Vector3.forward * speed * Time.fixedDeltaTime * movement.y +
            Vector3.right * speed * Time.fixedDeltaTime * movement.x;
    }

    private void DoSaltar(InputAction.CallbackContext obj)
    {
        // El cubo saltara
        mRb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);

    }

}
