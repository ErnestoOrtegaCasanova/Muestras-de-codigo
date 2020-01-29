using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 

public class puntuacion : MonoBehaviour {
    public static float _puntuacion = 0;
    public float _incremento = 0;
    public Text text;
    public float _scores = 0;

    //puntuacion para cada nave asignando etiquetas
  

    public void SetPuntuacion()
    {
        _incremento = _incremento + _scores;
           
    
        text.text = _incremento.ToString().PadLeft(9,'0');
    }

   // public void iPuntuacion()
   // {
        //text = GetComponent<Text>();

  
        //text.text = _incremento.ToString();
        //print(_incremento);
   // }

	//vamos a almorzar ahora venimos 

}
