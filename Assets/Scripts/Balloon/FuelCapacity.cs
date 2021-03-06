using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FuelCapacity : MonoBehaviour
{
    private float fuel;
    public float max_fuel = 100f;
    public float reductionRatio;
    // Start is called before the first frame update
    void Start()
    {
        fuel = max_fuel;
        reductionRatio = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        fuel= Math.Min(fuel - Time.deltaTime * reductionRatio, 100);
        // Debug.Log("Fuel: " + fuel.ToString());
        if(fuel <= 0){
            // Debug.Log("Fuel Empty of " + gameObject.name + ": " + fuel.ToString());
            GameObject.Find("Variables").GetComponent<Variables>().EndScene();
        }
    }

    public float GetFuel() {
        return fuel;
    } 

    public void ReductionCloud(float cloudReduction) {
        fuel = Math.Min(fuel - cloudReduction, 100);
    }

    public void FuelCollection(float increment) {
        fuel = Math.Min(fuel + increment, 100);
    }

    public void ReductionDrop(){
        fuel = Math.Min(fuel - 0.5f, 100);
    }
}
