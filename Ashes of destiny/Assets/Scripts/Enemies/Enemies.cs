using UnityEngine;
using UnityEngine.AI;

public class Enemies : MonoBehaviour
{
    NavMeshAgent agent;
    protected float health;
    protected float currentHealth;
    protected float maxHealth;
    protected Vector3 startPosition;
    void Start()
    {
        TryGetComponent(out agent);
        startPosition = transform.position;
        currentHealth = health;
    }
}
