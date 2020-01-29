using UnityEngine;
using System.Collections;

public class SSDamage : MonoBehaviour {
    public int _damage= 0;
    public puntuacion _score;
    // Use this for initialization
    void Start () {
        _score = GameObject.FindObjectOfType<puntuacion>();


    }

    // Update is called once per frame
    void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag.Equals("bala"))
        {    
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.tag.Equals("enemigo"))
        {
            _score.SetPuntuacion();
            Destroy(coll.gameObject);
        }
        if(coll.gameObject.tag.Equals("BalaE"))
        {
            Destroy(coll.gameObject);
        }
    }
}
