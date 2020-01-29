using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class HighScore : MonoBehaviour
{
    public static float _puntuacion = 0;
    public float _incr = 0;
    public Text text;
    public int _scores = 0;



    string scoreKey = "highscore";
    public int highScore = 0;



    void Start()
    {
        highScore = PlayerPrefs.GetInt(scoreKey, 0);
    }

    //puntuacion para cada nave asignando etiquetas

    /*  public void SetPuntuacion()
      {

          _incr = _incr + _scores;
          text.text = highScore.ToString().PadLeft(9, '0');


      }*/


    void Update()
    {
        if (_incr > highScore)
        {
            puntuacion variable = GetComponent<puntuacion>();
            _incr = variable._incremento;
            PlayerPrefs.SetInt(scoreKey, (int)_incr);
            PlayerPrefs.Save();
        }
    }





}
