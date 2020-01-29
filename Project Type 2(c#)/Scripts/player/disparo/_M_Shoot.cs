using UnityEngine;
using System.Collections;

public class _M_Shoot : MonoBehaviour
{
    public int id;
    public int daño = 1;
    public int contadordaño = 0;
    public float _force = 750;
    public rec_ST _laserContainer;
    public puntuacion _score;


    // Use this for initialization
    void Start()
    {
        _score = GameObject.FindObjectOfType<puntuacion>();
        _laserContainer = GameObject.FindObjectOfType<rec_ST>();
        //transform.localRotation = new Quaternion(0.0f, 1.0f, 0.0f, -90.0f);
    }

    // Update is called once per frame<d
    void Update()
    {


        Vector3 pos = transform.position;
        Vector3 _velocidad = new Vector3(_force * Time.deltaTime, 0, 0);
        Vector3 rot;
        if (this.id == 0)
        {
            rot = new Vector3(0, 0, 90.0f);
            pos += transform.rotation * _velocidad;
            transform.position = pos;
        }
        else
        {
            rot = new Vector3(0, 0, 90.0f);
            pos -= transform.rotation * _velocidad;
            transform.position = pos;
        }


     

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "enemigo") 
        {

            _score.SetPuntuacion();
           

            if (_laserContainer._contador != 0)
            {
                
                _laserContainer._contador--;
                _laserContainer.C_contador();
            }



			Destroy(this.gameObject);

            
        }if(coll.gameObject.tag == "Obstaculo")
        {
            Destroy(this.gameObject);
        }
			
		/**if (coll.gameObject.tag =="BalaE") {
			Destroy(this.gameObject);
			
		}*/


    }

   
}
