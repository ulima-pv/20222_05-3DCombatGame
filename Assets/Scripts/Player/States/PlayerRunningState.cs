using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunningState : State<PlayerController>
{
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
