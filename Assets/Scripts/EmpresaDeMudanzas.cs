using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpresaDeMudanzas : MonoBehaviour
{

    public float cantKm;
    public float cantKilos;
    float cantMaximaUtilitario = 2000;
    float cantMaximaPickup = 5000;
    float cantMaximaCamion = 10000;
    float precioPorHoraU = 3000;
    float precioPorHoraP = 4500;
    float precioPorHoraC = 7000;
    float precioFinal;
    string vehiculo;

    // Start is called before the first frame update
    void Start()
    {
        float cantHoras = cantKm / 25;
        if (cantKm <= 50)
        {
            if (cantKilos < 100)
            {
                Debug.Log("No se pueden transportar menos de 100 Kilos");
            }
            else if (cantKilos <= cantMaximaUtilitario)
            {
                precioFinal = precioPorHoraU * 2;
                vehiculo = "Utilitario";
                Debug.Log("Precio total por " + cantHoras + " horas a $" + precioPorHoraU + " en un " + vehiculo + " es de $" + precioFinal + " ya que se contratan vehículos por un mínimo de dos horas, cobrandote el precio de dos.");
            } else if (cantKilos > cantMaximaUtilitario && cantKilos <= cantMaximaPickup)
            {
                precioFinal = precioPorHoraP * 2;
                vehiculo = "Pickup";
                Debug.Log("Precio total por " + cantHoras + " horas a $" + precioPorHoraP + "en un " + vehiculo + " es de $" + precioFinal + " ya que se contratan vehículos por un mínimo de dos horas, cobrandote el precio de dos.");
            } else if (cantKilos > cantMaximaPickup && cantKilos <= cantMaximaCamion)
            {
                precioFinal = precioPorHoraC * 2;
                vehiculo = "Camión";
                Debug.Log("Precio total por " + cantHoras + " horas a $" + precioPorHoraC + " en un " + vehiculo + " es de $" + precioFinal + " ya que se contratan vehículos por un mínimo de dos horas, cobrandote el precio de dos.");
            } else if (cantKilos > cantMaximaCamion)
            {
                Debug.Log("Ninguno de mis vehículos puede transportar esa cantidad de kilos.");
            }
            else
            {
                Debug.Log("Hay un error entre los campos ingresados.");
            }
        }
        else
        {
            if (cantKilos < 100)
            {
                Debug.Log("No se pueden transportar menos de 100 Kilos");
            }
            else if (cantKilos <= cantMaximaUtilitario)
            {
                precioFinal = precioPorHoraU * cantHoras;
                vehiculo = "Utilitario";
                Debug.Log("Precio total por " + cantHoras + " horas a $" + precioPorHoraU + " en un " + vehiculo + " es de $" + precioFinal + ".");
            }
            else if (cantKilos > cantMaximaUtilitario && cantKilos <= cantMaximaPickup)
            {
                precioFinal = precioPorHoraP * cantHoras;
                vehiculo = "Pickup";
                Debug.Log("Precio total por " + cantHoras + " horas a $" + precioPorHoraP + " en un " + vehiculo + " es de $" + precioFinal + ".");
            }
            else if (cantKilos > cantMaximaPickup && cantKilos <= cantMaximaCamion)
            {
                precioFinal = precioPorHoraC * cantHoras;
                vehiculo = "Camión";
                Debug.Log("Precio total por " + cantHoras + " horas a $" + precioPorHoraC + " en un " + vehiculo + " es de $" + precioFinal + ".");
            }
            else if (cantKilos > cantMaximaCamion)
            {
                Debug.Log("Ninguno de mis vehículos puede transportar esa cantidad de kilos.");
            }
            else
            {
                Debug.Log("Hay un error entre los campos ingresados.");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
