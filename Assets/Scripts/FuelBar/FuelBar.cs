using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;
    private FuelCapacity fuelCapacity;
    public GameObject player;

    void Start()
    {
        fuelCapacity = player.GetComponent<FuelCapacity>();

        slider.maxValue = fuelCapacity.max_fuel;
        slider.value = fuelCapacity.GetFuel();

        fill.color = gradient.Evaluate(1f);
    }

    void Update()
    {
        slider.value = fuelCapacity.GetFuel();

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

}
