using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIVehicle : IVehicleInput
{
    public float Rotation { get; private set; }
    public float Move { get; private set; }

    public void ReadInput()
    {
        Rotation = Random.Range(-1f,1f);
        Move = 1f;
    }
}
