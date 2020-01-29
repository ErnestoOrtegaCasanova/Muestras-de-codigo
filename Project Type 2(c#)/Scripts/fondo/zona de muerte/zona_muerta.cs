using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class zona_muerta : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D destruir)
    {
        if (destruir.gameObject.tag == "enemigo") {
            Destroy(destruir.gameObject);
        }
        if (destruir.gameObject.tag.Equals("BalaE"))
        {
            Destroy(destruir.gameObject);

        }
        if (destruir.gameObject.tag.Equals("SS"))
        {
            Destroy(destruir.gameObject);
         
        }
        

    }


}
