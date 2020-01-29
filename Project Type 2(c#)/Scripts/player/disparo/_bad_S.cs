using UnityEngine;
using System.Collections;

public class _bad_S : MonoBehaviour
{
    public int daño = 1;
    public int contadordaño = 0;
    float _force = 750;
    public rec_ST _laserContainer;
    public Test _daño;

    // Use this for initialization
    void Start()
    {
        _laserContainer = GameObject.FindObjectOfType<rec_ST>();
        //transform.localRotation = new Quaternion(0.0f, 1.0f, 0.0f, -90.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 _velocidad = new Vector3(_force * Time.deltaTime, 0, 0);
        var rot = new Vector3(0, 0, -90.0f);

        pos += transform.rotation * _velocidad;
        transform.position = pos;

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "nave buena")
        {
            //que se destruya el disparo y la nave buena se le reste uno de vida
            //Destroy(this.gameObject);
            _daño.count++;
        }
        if (coll.gameObject.tag == "Obstaculo")
        {
            Destroy(this.gameObject);
        }

    }
}

