using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class rec_ST : MonoBehaviour {
    public Image shoot;
    //maximo de tiros para llenar la barra
    public float _maxCharge = 40;
    public float _contador = 0;
    public Button _mybutton;
    public int daño = 1;
    // Use this for initialization
	void Start () {

        C_contador();
        
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            if(_contador != 40)
                _contador++;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            if ( _contador != 0) { _contador--; }   
        }
         C_contador();

        if (_contador == 0)
        {
            _mybutton.enabled = true;
        }
        else
            _mybutton.enabled = false;
    
       }

           
    //Funcion para subir el nivel de la gema 
    public void C_contador()
    {
        shoot.fillAmount = (_maxCharge - _contador) / _maxCharge;
    }

    public void Disparar()
    {
        _contador = 40;
    }

    public void powerup()
    {
        
        _contador = 0;
    }

    //prueba colisionador 
    /* void OnTriggerEnter(Collision2D full)
    {
        if(full.gameObject.tag.Equals("player"))
        {
            Destroy(full.gameObject);
            powerup();
        }
    }*/
   
 
}
