using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    [SerializeField]
    protected Transform body, viewPoint;

    [SerializeField]
    protected FieldView fieldView;

    [SerializeField]
    protected NavMeshAgent agent;

    public Transform Body {  get { return body; } }
    public FieldView FieldView { get { return fieldView; } }

    protected virtual void Start()
    {
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    protected void RotateToTarget(Transform target)
    {
        float angle = Mathf.Atan2(target.position.y - body.position.y, target.position.x - body.position.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
        fieldView.RotationView(targetRotation);
    }
}
