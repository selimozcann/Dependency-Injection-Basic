using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private VehicleSettings vehicleSettings;

    private IVehicleInput vehicleInput;
    private VehicleManager vehicleManager;

    private void Awake()
    {
        vehicleInput = vehicleSettings.UseAi ? new AIVehicle() : new VehicleController();

        vehicleManager = new VehicleManager(vehicleInput,transform,vehicleSettings);
    }
    private void Update()
    {
        vehicleInput.ReadInput();
        vehicleManager.VehicleMoving();
    }
}
