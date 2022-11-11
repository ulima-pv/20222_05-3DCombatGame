using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Targeter : MonoBehaviour
{
    public CinemachineTargetGroup CamaraGroup;
    private List<Target> mTargets = new List<Target>();
    private Animator mAnimator;

    private void Start()
    {
        InputManager.Instance.AddOnFocusHandler(SelectTarget);
        mAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            var target = other.GetComponent<Target>();
            if (target != null)
            {
                mTargets.Add(target);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            var target = other.GetComponent<Target>();
            if (target != null)
            {
                mTargets.Remove(target);
            }
        }
    }

    public void SelectTarget(object sender, EventArgs e)
    {
        if (mTargets.Count > 0)
        {
            
            mAnimator.Play("Targeting");
            CamaraGroup.AddMember(mTargets[0].transform, 1f, 2f);
        }
    }
}
