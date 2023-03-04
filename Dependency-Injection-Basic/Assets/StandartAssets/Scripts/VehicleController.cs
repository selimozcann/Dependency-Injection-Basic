using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : IVehicleInput
{
    public float Rotation { get; private set; }
    public float Move { get; private set; }

    public void ReadInput()
    {
        //<summary>
        //Rotation and Move are example assign values.
        //</summary>
        Rotation = 0;
        Move = Input.GetAxis("Vertical");
    }
}
