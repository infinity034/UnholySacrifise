using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    [SerializeField]
    private Transform body;

    public Transform Body {  get { return body; } }

    private void Awake()
    {
        Instance = this;
    }
}
