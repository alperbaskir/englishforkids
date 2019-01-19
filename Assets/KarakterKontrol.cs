using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KarakterKontrol : MonoBehaviour {
    public Text altinmiktar;
    public int altin;
    public AudioClip[] sounds;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        altinmiktar.text = "" + altin; //altın göstergesi update
        if (altin == 20)
        {
            Application.LoadLevel("Ending");
        }
        float h = Input.GetAxisRaw("Horizontal"); //oyun hızı update
        transform.Translate(new Vector2(h * Time.deltaTime*3, 0));
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        
        Application.LoadLevel("GameOver");
        //print("Çarpışma Oldu");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void OnTriggerEnter2D(Collider2D nesne)
    {
        if (nesne.gameObject.tag == "gold")
        {
            altin++;
            GetComponent<AudioSource>().PlayOneShot(sounds[0]);
            Destroy(nesne.gameObject);
            
        }
        if (nesne.gameObject.tag=="monkey")
        {
            GetComponent<AudioSource>().PlayOneShot(sounds[1]);
            Destroy(nesne.gameObject);
        }
        if (nesne.gameObject.tag == "elephant")
        {
            GetComponent<AudioSource>().PlayOneShot(sounds[2]);
            Destroy(nesne.gameObject);
        }
        if (nesne.gameObject.tag == "panda")
        {
            GetComponent<AudioSource>().PlayOneShot(sounds[3]);
            Destroy(nesne.gameObject);
        }
        if (nesne.gameObject.tag == "rabbit")
        {
            GetComponent<AudioSource>().PlayOneShot(sounds[4]);
            Destroy(nesne.gameObject);
        }
        if (nesne.gameObject.tag == "parrot")
        {
            GetComponent<AudioSource>().PlayOneShot(sounds[5]);
            Destroy(nesne.gameObject);
        }
        if (nesne.gameObject.tag == "penguin")
        {
            GetComponent<AudioSource>().PlayOneShot(sounds[6]);
            Destroy(nesne.gameObject);
        }
        if (nesne.gameObject.tag == "snake")
        {
            GetComponent<AudioSource>().PlayOneShot(sounds[7]);
            Destroy(nesne.gameObject);
        }
        if (nesne.gameObject.tag == "giraffe")
        {
            GetComponent<AudioSource>().PlayOneShot(sounds[8]);
            Destroy(nesne.gameObject);
        }
        if (nesne.gameObject.tag == "pig")
        {
            GetComponent<AudioSource>().PlayOneShot(sounds[9]);
            Destroy(nesne.gameObject);
        }

    }
    

   
}
