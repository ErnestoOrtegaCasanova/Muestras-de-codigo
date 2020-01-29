using UnityEngine;
using System.Collections;

public class disparar : MonoBehaviour
{
    public float fireDelay = 0.25f;
    float CD = 0;

    public GameObject _bala;
    public RectTransform _initPos;
    public Transform _shootparent;
    public bool _spawned = true;
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

	void Start(){
		mouseDown = false;
	}
    // Update is called once per frame
    void Update()
    {
		
        if (mouseDown)
        {
            prueba();
        }


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
        if (_spawned)
        {
            var bala = Instantiate(_bala, _initPos.position, Quaternion.identity) as GameObject;

            bala.transform.SetParent(_shootparent, true);

            bala.transform.SetParent(GameObject.Find("ShootPool").gameObject.transform, true);

            _spawned = false;
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
	{
        
		if (coll.gameObject.tag.Equals ("enemigo")) {
			Destroy (coll.gameObject);
			_daño.count++;
		}
		if (coll.gameObject.tag.Equals ("BalaE")) {
			Destroy (coll.gameObject);
			_daño.count++;
		}
	}
}
