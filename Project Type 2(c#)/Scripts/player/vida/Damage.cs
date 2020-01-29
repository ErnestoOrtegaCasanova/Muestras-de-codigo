using UnityEngine;
using System.Collections;


public class Damage : MonoBehaviour
{
    public int vida = 2;
    public rec_ST _laserContainer;
    

    void Start()
    {
        _laserContainer = GameObject.FindObjectOfType<rec_ST>();
    }
    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag.Equals("bala"))
            vida = vida - _laserContainer.daño;

        if (vida == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
    



    
