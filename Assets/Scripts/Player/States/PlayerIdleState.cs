using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : State<PlayerController>
{
    public PlayerIdleState(
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
        if (InputManager.Instance.Movement != Vector2.zero)
        {
            // Cambiar a un estado RunningState
            mFsm.ChangeState(mController.PlayerRunningState);
        }
    }

    public override void OnPhysicsUpdate()
    {
        base.OnPhysicsUpdate();
    }

    public override void OnStart()
    {
        base.OnStart();
    }

    public override void OnStop()
    {
        base.OnStop();
    }
}
