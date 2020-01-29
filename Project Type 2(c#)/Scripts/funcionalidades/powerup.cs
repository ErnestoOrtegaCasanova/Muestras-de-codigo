using UnityEngine;
using System.Collections;

public class powerup : MonoBehaviour {

    public rec_ST _powerup;
	void Start () {
        _powerup = GameObject.FindObjectOfType<rec_ST>();
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag.Equals("player"))
        {
            _powerup._contador = 0;
            Destroy(coll.gameObject);
        }
    }	
}
