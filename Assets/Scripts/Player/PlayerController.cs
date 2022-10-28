using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 6f;
    public float dampTime = 0.1f;

    private Rigidbody mRb;
    private Animator mAnimator;
    private FiniteStateMachine<PlayerController> mFsm;

    // States
    public State<PlayerController> PlayerIdleState;
    public State<PlayerController> PlayerRunningState;

    private void Awake()
    {
        mRb = GetComponent<Rigidbody>();
        mAnimator = GetComponent<Animator>();

        mFsm = new FiniteStateMachine<PlayerController>();
        PlayerIdleState = new PlayerIdleState(this, mFsm);
        PlayerRunningState = new PlayerRunningState(this, mFsm);
    }

    private void Start()
    {
        mFsm.Start(PlayerIdleState);
    }

    private void FixedUpdate()
    {
        mFsm.CurrentState.OnPhysicsUpdate();
    }

    private void Update()
    {
        mFsm.CurrentState.HandleInput();
        mFsm.CurrentState.OnLogicUpdate();
    }

}
