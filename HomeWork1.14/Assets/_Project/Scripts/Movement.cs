using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public Transform Goal;
    private NavMeshAgent _agent;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        _agent.destination = Goal.position;
    }
}
