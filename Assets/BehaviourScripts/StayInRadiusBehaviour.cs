using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behaviour/StayInRadius")]
public class StayInRadiusBehaviour : FlockBehaviour
{
    public Vector3 center;
    public float radius = 15f;
    public float middleDrag;

    public override Vector3 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        Vector3 centerOffset = center - agent.transform.position;
        float t = centerOffset.magnitude / radius;
        if (t < 0.9f)
        {
            return centerOffset.normalized * middleDrag;
        }

        return centerOffset * t;
    }

}
