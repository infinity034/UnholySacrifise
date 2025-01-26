using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EventPatrol
{
    public int specificDay; // If 0, every day

    [SerializeField]
    private float timeToProc;

    public float TimeToProc { get {  return timeToProc / DayClock.Instance.DayTime; } }

    public List<Transform> patrolPoints;
}
