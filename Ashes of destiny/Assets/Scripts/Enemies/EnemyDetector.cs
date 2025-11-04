using UnityEngine;

public class EnemyDetector : Enemies
{
    [SerializeField] LayerMask layerPlayer;
    [SerializeField] float radius;

    private void Update()
    {
        Physics.OverlapSphere(transform.position, radius, layerPlayer);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
