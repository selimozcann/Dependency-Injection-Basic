using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVehicleInput
{
    void ReadInput();
    float Rotation { get; }
    float Move { get; }
}
