using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public EnemySO enemyData;

    public Transform target;

    private CharacterController mCharacterController;

    private void Start()
    {
        mCharacterController = GetComponent<CharacterController>();

        Instantiate(
            enemyData.prefab,
            transform.position,
            Quaternion.identity,
            transform
        );
    }

    private void Update()
    {
        var dir = target.position - transform.position;
        dir.y = 0f;
        dir.Normalize();

        mCharacterController.Move(
            (Vector3.right * dir.x + Vector3.forward * dir.z)
            * enemyData.speed * Time.deltaTime
        ); ;
    }

    public void Hurt()
    {
        Debug.Log("Hizo danho al cubo");
    }
}
