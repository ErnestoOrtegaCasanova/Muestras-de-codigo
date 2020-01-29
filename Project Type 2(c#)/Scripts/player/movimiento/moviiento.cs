using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class moviiento : MonoBehaviour {

    public int Velocidad = 5;

	private int layerEnemigo;
	private int layerBalaE;
	private int layerPlayer;

	// Use this for initialization
	void Start () {
	


	}

    // Update is called once per frame
    void Update() {

        
        
        transform.position += (new Vector3(CnControls.CnInputManager.GetAxis("Horizontal") * Velocidad * Time.deltaTime, CnControls.CnInputManager.GetAxis("Vertical") * Velocidad * Time.deltaTime, 0));
            
    }

	public void ActivarLayers()
	{
		
		this.gameObject.layer = 12;

	}


	public void DesactivarLayers()
	{

		this.gameObject.layer = 14;
	}



}
