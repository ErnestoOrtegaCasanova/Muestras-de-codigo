using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spamear : MonoBehaviour {

    public GameObject F_Delta;
    public RectTransform _initPos;
    public Transform _Enemiparent;
    GameObject F_DeltaClone;
    [Header("Escala Enemigos")]
    public Vector3[] escala;
    public  GameObject[] formaciones;
    int result;

    private Dictionary<GameObject, Vector3> _myDictionary = new Dictionary<GameObject, Vector3>();

    public void Start()
    {
        InvokeRepeating("Lanzar",2,6);
        if (escala.Length != formaciones.Length)
        {
            Debug.LogError("Los arrays escala y formciones han de medir lo mismo");
        }
        else
        {
            for (int i = 0; i < formaciones.Length; i++)
                _myDictionary.Add(formaciones[i], escala[i]);

           }
    }

	public void Lanzar()
    {

        var num = Random.Range(0, formaciones.Length);
        F_DeltaClone = Instantiate(formaciones[num], transform.position, Quaternion.identity) as GameObject;
        F_DeltaClone.transform.SetParent(_Enemiparent, true);
        F_DeltaClone.transform.localScale = _myDictionary[formaciones[num]];
        //F_DeltaClone.transform.SetParent(GameObject.Find("EnemieSpawn").gameObject.transform, false);
       
    }
}

