using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Enemy"))
        {
            if (other.GetComponent<EnemyController>() == null) return;
            
            other.GetComponent<EnemyController>().Hurt();
        }
    }
}
