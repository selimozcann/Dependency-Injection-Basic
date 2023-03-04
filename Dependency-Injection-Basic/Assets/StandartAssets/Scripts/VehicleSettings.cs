using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VehicleSettings")]
public class VehicleSettings : ScriptableObject
{
    [SerializeField] private float turnSpeed = 25f;
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private bool useAi = false;


    public float MoveSpeed { get { return moveSpeed; } }
    public float TurnSpeed { get { return turnSpeed; }  }

    public bool UseAi { get { return useAi; }  }
}
