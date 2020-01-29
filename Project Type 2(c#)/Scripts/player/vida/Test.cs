using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class Test : MonoBehaviour {

	public List<Image> HealthImagesList;
	int counthealth = 3;

    public Image _mybar;
    public float _maxDmg = 5; //numero de toqus

    public float count = 0; //toque sque llevo
	// Use this for initialization
	private bool lifeloss = false;
	private int  maxlifes = 2;
	public GameObject player;
	public GameObject gOver;
	void Start () {

        CheckCount();

    }

    // Update is called once per frame
    void Update()
    {
       

       CheckCount();
    }
    
        

     public void CheckCount()
    {
        if (count == _maxDmg)
        {
			lifeloss = true;
			if (lifeloss && maxlifes >= 0) {


				Destroy (HealthImagesList [maxlifes].gameObject);
				maxlifes--;
				lifeloss = false;
				player.GetComponent<Animator> ().SetTrigger ("Blink");


			} else {
				maxlifes--;
			}


            //Destroy(GameObject.FindGameObjectWithTag("Player"));


//			if (counthealth == 0) {
//				Debug.Log ("SIN VIDAS");
//				counthealth = 0;
//			}

			count = 0;

			if (maxlifes < 0)
			{
				GameOverEvent ();
			}
        }
            _mybar.fillAmount = (_maxDmg - count) / _maxDmg;
    }

	private void GameOverEvent()
	{
		Destroy (player.transform.parent.gameObject);
		Destroy(GameObject.Find ("Joystick"));
		gOver.SetActive (true);
		gOver.GetComponent<Animator> ().SetTrigger ("gameover");


		   
	}
}
