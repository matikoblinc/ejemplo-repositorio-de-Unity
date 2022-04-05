//9. Realizá un programa que resuelva el siguiente problema:  
//Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del
//total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar 
//lo pedido en el siguiente formato:  
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    public string nombre1;
    public float capital1;
    public string nombre2;
    public float capital2;
    public string nombre3;
    public float capital3;
    float MontoTotal;
    float porcentaje1;
    float porcentaje2;
    float porcentaje3;
    
    void Start()
    {
        MontoTotal = capital1 + capital2 + capital3;

        porcentaje1 = (capital1 / MontoTotal) * 100;
        porcentaje2 = (capital2 / MontoTotal) * 100;
        porcentaje3 = (capital3 / MontoTotal) * 100;

        Debug.Log("Nombre: " + nombre1 + " Capital aportado: $" + capital1 + " Porcentaje del capital: " + porcentaje1 + 
            "% Monto total: " + MontoTotal);
        Debug.Log("Nombre: " + nombre2 + " Capital aportado: $" + capital2 + " Porcentaje del capital: " + porcentaje2 +
            "% Monto total: " + MontoTotal);
        Debug.Log("Nombre: " + nombre3 + " Capital aportado: $" + capital3 + " Porcentaje del capital: " + porcentaje3 + 
            "% Monto total: " + MontoTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
