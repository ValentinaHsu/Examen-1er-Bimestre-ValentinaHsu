using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animalitos : MonoBehaviour
{
    public string codigo;
    public int dias;

    // Start is called before the first frame update
    void Start()
    {
        int alimento;
        int precio;
        if (dias >= 3)
        {
            if (codigo == "G")
            {
                alimento = 300 * dias;
                precio = alimento / 100 * 80;
                Debug.Log("Para ese período se necesitan " + alimento + " gramos de alimento.");
                Debug.Log("El costo sera de $" + precio);

            }
            else if (codigo == "PP")
            {
                alimento = 400 * dias;
                precio = alimento / 100 * 80;
                Debug.Log("Para ese período se necesitan " + alimento + " gramos de alimento.");
                Debug.Log("El costo sera de $" + precio);
            }
            else if (codigo == "PG")
            {
                alimento = 700 * dias;
                precio = alimento / 100 * 80;
                Debug.Log("Para ese período se necesitan " + alimento + " gramos de alimento.");
                Debug.Log("El costo sera de $" + precio);
            }
            else
            {
                Debug.Log("El codigo ingresado no es valido");
            }
        }
        else
        {
            Debug.Log("La cantidad de dias no puede ser menor de 3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
