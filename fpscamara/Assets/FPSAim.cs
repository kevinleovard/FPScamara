using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSAim : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

public bool InvertedMouse;//variable booleana para invertir o no la camara//
    float mouseX;// asignamos variable X//
    float mouseY;// asignamos variable Y//
    void Update()
    {
        Vector3 mousePosition=Input.mousePosition;//asignar posicion del mouse//
        Debug.Log(mousePosition);// mostrar en pantalla la posicion del mouse//
        Debug.Log(transform.localRotation);//mostrar en pantalla  la rotacion del objeto//
        
        mouseX += Input.GetAxis("Mouse X");//mostrar la posicion del eje X//

        mouseY -= Input.GetAxis("Mouse Y");//accion falsa//
        
        Debug.Log(mouseX);//muestra la posicion del eje X//
        transform.eulerAngles = new Vector3 (mouseY,mouseX,0);//

    }
}
