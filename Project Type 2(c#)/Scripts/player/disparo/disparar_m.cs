using UnityEngine;
using System.Collections;

public class disparar_m : MonoBehaviour
{

  
    public float fireDelay = 0.25f;
    float CD = 0;

    public GameObject _bala;
    public RectTransform _initPos;
    public Transform _shootparent;

    public static bool mouseDown;
    public float timeMouseDown;
    public bool _spawned = true;

    /* BORRAR **/

    public Test _daño;


    // Use this for initialization
    void Start()
    {
        _daño = GameObject.FindObjectOfType<Test>();
    }

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

        if(_spawned)
        {
            var bala = Instantiate(_bala, _initPos.position, Quaternion.identity) as GameObject;

            bala.transform.SetParent(_shootparent, true);

            bala.transform.SetParent(GameObject.Find("ShootPool").gameObject.transform, true);

            _spawned = false;
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
       

     
		if (other.gameObject.tag.Equals ("muerte")) {
			Destroy (other.gameObject);
		}
    }
}


