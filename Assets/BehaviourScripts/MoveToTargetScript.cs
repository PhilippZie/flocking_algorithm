using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behaviour/MoveToTarget")]
public class MoveToTargetBehaviour : FlockBehaviour
{
    public override Vector3 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        Vector3 targetMove = Vector3.zero;
        if (flock.followTarget)
        {
            Vector3 targetPos = flock.target.transform.position;
            Vector3 direction = targetPos - agent.transform.position;
            targetMove = direction.normalized;
        }
        return targetMove;
    }
}