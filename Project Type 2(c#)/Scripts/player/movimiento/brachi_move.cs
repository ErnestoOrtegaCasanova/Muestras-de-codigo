using UnityEngine;
using System.Collections;

public class brachi_move : MonoBehaviour {

    public float _force = 100;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = transform.position;
        Vector3 _velocidad = new Vector3(0, 0, _force * -Time.deltaTime);
        var rot = new Vector3(0, 0, 0);

        pos += transform.rotation * _velocidad;
        transform.position = pos;

    }
}
