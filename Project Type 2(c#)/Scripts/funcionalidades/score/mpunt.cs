using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class mpunt : MonoBehaviour
{
    public static float _puntuacion = 0;
    public Text text;
    public float _incr;

    public static puntuacion datos;




    string scoreKey = "highscore";
    public int highScore = 0;



    void Start()
    {




        highScore = PlayerPrefs.GetInt(scoreKey, 0);
    }

    //puntuacion para cada nave asignando etiquetas


    void Update()
    {
        text.text = highScore.ToString().PadLeft(9, '0');

        datos = GameObject.Find("scores").GetComponent<puntuacion>();
        _incr = datos._incremento;


        if ((int)_incr > highScore)
        {
            PlayerPrefs.SetInt(scoreKey, (int)_incr);
            PlayerPrefs.Save();
        }
    }





}