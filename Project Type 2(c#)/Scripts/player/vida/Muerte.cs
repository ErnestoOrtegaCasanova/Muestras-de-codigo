using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Muerte : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("enemigo"))
        {
            Destroy(this.gameObject);
        }
    }


}
