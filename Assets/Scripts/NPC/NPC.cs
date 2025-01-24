using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField]
    protected Transform body;

    [SerializeField]
    protected FieldView fieldView;

    public Transform Body {  get { return body; } }

    protected virtual void Awake()
    {
        
    }

    protected void RotateToTarget(Transform target)
    {
        float angle = Mathf.Atan2(target.position.y - body.position.y, target.position.x - body.position.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
        fieldView.RotationView(targetRotation);
    }
}
