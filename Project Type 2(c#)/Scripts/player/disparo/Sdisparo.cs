using UnityEngine;
using System.Collections;

public class Sdisparo : MonoBehaviour {

    public int id;
    public int daño = 1;
    public int contadordaño = 0;
    public float _force = 750;
    public puntuacion _score;
    public Test _daño;
    public GameObject _Sshot;
    public RectTransform _initPos;
    public Transform _shootparent;


    // Use this for initialization
    void Start () {
        _score = GameObject.FindObjectOfType<puntuacion>();


    }

    // Update is called once per frame
    void Update () {
    
	}
    public void instanciar()
    {
        var Sshot = Instantiate(_Sshot, _initPos.position, Quaternion.identity) as GameObject;
        Sshot.transform.SetParent(_shootparent, true);
        Sshot.transform.SetParent(GameObject.Find("SpawnerShot").gameObject.transform, true);


    }
    void OnTriggerEnter2D(Collider2D sShot)
    {
        if (sShot.gameObject.tag == "enemigo")
        {

            _score.SetPuntuacion();

        }

    }

}
