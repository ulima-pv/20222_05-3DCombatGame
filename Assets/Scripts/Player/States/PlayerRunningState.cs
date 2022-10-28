using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunningState : State<PlayerController>
{
    private CharacterController mCharacterController;
    private Animator mAnimator;

    public PlayerRunningState(
        PlayerController controller, 
        FiniteStateMachine<PlayerController> fsm) : base(controller, fsm)
    {}

    public override void HandleInput()
    {
        base.HandleInput();
    }

    public override void OnLogicUpdate()
    {
        base.OnLogicUpdate();

        Vector3 movementVector = Vector3.right * InputManager.Instance.Movement.x +
            Vector3.forward * InputManager.Instance.Movement.y;

        mCharacterController.Move(
            movementVector * Time.deltaTime * mController.speed
        );

        if (InputManager.Instance.Movement == Vector2.zero)
        {
            mAnimator.SetFloat("Speed", 0f, mController.dampTime, Time.deltaTime);
            // Regresar al Idle State
            mFsm.ChangeState(mController.PlayerIdleState);
        }
        else
        {
            mAnimator.SetFloat("Speed", 1f, mController.dampTime, Time.deltaTime);
        }

    }

    public override void OnPhysicsUpdate()
    {
        base.OnPhysicsUpdate();
    }

    public override void OnStart()
    {
        base.OnStart();
        mCharacterController = mController.GetComponent<CharacterController>();
        mAnimator = mController.GetComponent<Animator>();
    }

    public override void OnStop()
    {
        base.OnStop();
    }
}
