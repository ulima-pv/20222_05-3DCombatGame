using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunningState : State<PlayerController>
{
    private CharacterController mCharacterController;

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
        if (InputManager.Instance.Movement == Vector2.zero)
        {
            // Regresar al Idle State
            mFsm.ChangeState(mController.PlayerIdleState);
        }

        Vector3 movementVector = Vector3.right * InputManager.Instance.Movement.x +
            Vector3.forward * InputManager.Instance.Movement.y;

        mCharacterController.Move(
            movementVector * Time.deltaTime * mController.speed
        );
    }

    public override void OnPhysicsUpdate()
    {
        base.OnPhysicsUpdate();
    }

    public override void OnStart()
    {
        base.OnStart();
        mCharacterController = mController.GetComponent<CharacterController>();
    }

    public override void OnStop()
    {
        base.OnStop();
    }
}
