using UnityEngine;
using UnityEngine.AI;

namespace Enemies.generic
{
    public class EnemyAnimationHandler : MonoBehaviour
    {
        private void Start()
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.updateRotation = false;
            agent.updateUpAxis = false;
            
        }

    }
}