using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public EnemySO enemyData;

    public Transform target;

    private CharacterController mCharacterController;
    private NavMeshAgent mNavMeshAgent;

    private void Start()
    {
        mCharacterController = GetComponent<CharacterController>();
        mNavMeshAgent = GetComponent<NavMeshAgent>();
        mNavMeshAgent.velocity = new Vector3(enemyData.speed, 0f, enemyData.speed);
        mNavMeshAgent.destination = target.position;

        Instantiate(
            enemyData.prefab,
            transform.position,
            Quaternion.identity,
            transform
        );
    }

    private void Update()
    {
        mNavMeshAgent.destination = target.position;
    }

    public void Hurt()
    {
        Debug.Log("Hizo danho al cubo");
    }
}
