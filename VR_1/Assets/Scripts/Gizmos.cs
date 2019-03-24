using System;
using System.Collections;

using UnityEngine;

public class Gizmos : MonoBehaviour
{
    private static Color color;
    public float gizmoSize = 0.75f;
    public Color gizmoColor = Color.blue;

    void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(transform.position, gizmoSize);
    }

    private static void DrawWireSphere(Vector3 position, float gizmoSize)
    {
        throw new NotImplementedException();
    }
}
