using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Util : MonoBehaviour {
    public GameObject _nave1;
    public GameObject _nave2;
    string escena;

    public void reset() {


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

        public void Seleccion1()
    {
        SceneManager.LoadScene("p1");

    }
    public void Seleccion2()
    {
        SceneManager.LoadScene("p1R");

    }
}


