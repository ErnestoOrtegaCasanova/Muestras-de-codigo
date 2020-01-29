using UnityEngine;
using System.Collections;

public class Mov_Formacion : MonoBehaviour {

    float _force = 750;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 _velocidad = new Vector3(_force * Time.deltaTime, 0, 0);
        var rot = new Vector3(0, 0, -90.0f);
    }
}
