using UnityEngine;
using UnityEngine.AI;

public class NewEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform target;
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
