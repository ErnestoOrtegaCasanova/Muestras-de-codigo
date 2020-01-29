using UnityEngine;
using System.Collections;

public class dispararmalo : MonoBehaviour
{
    public float fireDelay = 0.25f;
    float CD = 0;

    public GameObject _bala;
    public RectTransform _initPos;
    public Transform _shootparent;

    public static bool mouseDown;
    public float timeMouseDown;

    /* BORRAR **/

    public Test _daño;

    public void OnPointerDown()
    {
        mouseDown = true;
    }
    public void OnPointerUp()
    {
        mouseDown = false;
        timeMouseDown = 0;
    }
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {        
            prueba();      


    }
    public void prueba()
    {

        CD += Time.deltaTime;
        if (CD > this.fireDelay)
        {
            var bala = Instantiate(_bala, _initPos.position, Quaternion.identity) as GameObject;

            bala.transform.SetParent(_shootparent, true);

            bala.transform.SetParent(GameObject.Find("ShootPool").gameObject.transform, true);

            CD = 0.0f;
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //Si el disparo entra en contacto con la nave buena le resta uno a la vida 
        if (coll.gameObject.tag.Equals("Player"))
        {
            Destroy(coll.gameObject);
            _daño.count++;
        }
    }
}


