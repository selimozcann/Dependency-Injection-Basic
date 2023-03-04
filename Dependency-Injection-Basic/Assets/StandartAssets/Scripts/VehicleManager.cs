using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleManager
{

   private readonly VehicleSettings vehicleSettings;
   private readonly Transform baseTransform;
   private readonly IVehicleInput vehicleInput;

   public VehicleManager(IVehicleInput vehicleInput,Transform baseTransform,VehicleSettings vehicleSettings)
   {
        this.vehicleInput = vehicleInput;
        this.baseTransform = baseTransform;
        this.vehicleSettings = vehicleSettings;
   }
   public void VehicleMoving()
   {
        baseTransform.Rotate(Vector3.up * vehicleInput.Rotation * vehicleSettings.TurnSpeed * Time.deltaTime);
        baseTransform.position += baseTransform.forward * Time.deltaTime  * vehicleInput.Move * vehicleSettings.MoveSpeed * Time.deltaTime;
   }
}
