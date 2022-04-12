using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvercionMoneda : MonoBehaviour
{

    public int argentinos;
    public string monedaextranjera;

    // Start is called before the first frame update
    void Start()
    {
        int dolares = argentinos / 188;
        int euros = argentinos / 120;
        int reales = argentinos / 20;

        if (argentinos < 1000)
        {
            Debug.Log("El monto debe ser mayor a 1000");
        }

        else if (1000 < argentinos)
        {

            switch (monedaextranjera)
            {
                    case "D": Debug.Log (argentinos+ "pesos argentinos son iguales a: " + dolares);
                    break;
                    case "E": Debug.Log (argentinos+ "pesos argentinos son iguales a: "+ euros);
                    break;
                    case "R": Debug.Log (argentinos+ "pesos argentino son iguales a: "+ reales);
                    break;
                    default: Debug.Log ("Opcion de moneda extranjera no valida");
                    break;

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
