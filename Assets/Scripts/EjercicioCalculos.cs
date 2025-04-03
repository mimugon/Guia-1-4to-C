using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCalculos : MonoBehaviour
{

    public float num1;
    public float num2;
    private float resultadoSuma;
    private float resultadoResta;
    private float resultadoDivision;
    private float resultadoMult;

    // Start is called before the first frame update
    void Start()
    {

        resultadoSuma = num1 + num2;
        Debug.Log(resultadoSuma);

        resultadoResta = num1 - num2;
        Debug.Log(resultadoResta);

        resultadoDivision = num1 / num2;
        Debug.Log(resultadoDivision);

        resultadoMult = num1 * num2;
        Debug.Log(resultadoMult);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
