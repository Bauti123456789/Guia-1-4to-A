using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    public float montoAConvertir;
    public string codigoMoneda;
    float cotizacionMoneda;
    float montoConvertido;

    float cotizacionDolar = 1075.43f;
    float cotizacionEuro = 1173.62f;
    float cotizacionReal = 182.659f;
    float minimoAConvertir = 1000;

    // Start is called before the first frame update
    void Start()
    {
        if (montoAConvertir < minimoAConvertir) 
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }

        if (codigoMoneda == "D") 
        {
            cotizacionMoneda = cotizacionDolar;
        }

        else if (codigoMoneda == "E") 
        {
            cotizacionMoneda = cotizacionEuro;
        }

        else if (codigoMoneda == "R") 
        {
            cotizacionMoneda = cotizacionReal;
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }

        montoConvertido = montoAConvertir / cotizacionMoneda;

        Debug.Log("El monto convertido es: " + montoConvertido);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
