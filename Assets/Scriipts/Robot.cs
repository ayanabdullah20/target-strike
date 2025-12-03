using UnityEngine;
using UnityEngine.AI;

public class RobotScript : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
