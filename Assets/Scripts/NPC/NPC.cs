using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField]
    protected Transform body;

    [SerializeField]
    protected FieldView fieldView;

    protected virtual void Awake()
    {
        fieldView = GetComponentInChildren<FieldView>();
    }
}
