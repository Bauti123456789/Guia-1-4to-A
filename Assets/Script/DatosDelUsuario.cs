using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    [SerializeField] int edadUsuario;
    public float estaturaUsuario;
    public bool donanteDeOrganos;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombreUsuario);
        Debug.Log("Tengo " + edadUsuario + "años");
        Debug.Log("Mido " + estaturaUsuario + "metros");
        Debug.Log("Es " + donanteDeOrganos + " que soy donante de organos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
