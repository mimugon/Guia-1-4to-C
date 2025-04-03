using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCalculos : MonoBehaviour
{

    public float num1;
    public float num2;
    private float resultado;

    // Start is called before the first frame update
    void Start()
    {

        resultado = num1 + num2;
        Debug.Log("El resultado de " + num1 + " + " + num2 + " es " + resultado);

        resultado = num1 - num2;
        Debug.Log("El resultado de " + num1 + " - " + num2 + " es " + resultado);

        resultado = num1 * num2;
        Debug.Log("El resultado de " + num1 + " por " + num2 + " es " + resultado);

        resultado = num1 / num2;
        Debug.Log("El resultado de " + num1 + " dividido " + num2 + " es " + resultado);

    }
        // Update is called once per frame
        void Update()
    {
    }
}
