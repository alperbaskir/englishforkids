using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenager : MonoBehaviour {
    public Transform aktifSetler, pasifSetler;
    public float KarakterHiz;
    private Transform randomSet;
    void  awake()
    {

    }
	// Use this for initialization
	void Start () {
        StartCoroutine(CheckForVisibilty());
        StartCoroutine(Move());
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}
    void Recycle()
    {
        Transform randomSet = pasifSetler.GetChild(Random.Range(0, pasifSetler.childCount));
        randomSet.parent = aktifSetler;
        randomSet.SetAsLastSibling();
        randomSet.localPosition = aktifSetler.GetChild(aktifSetler.childCount - 2).localPosition + new Vector3(0, 8, 0);

        randomSet = aktifSetler.GetChild(0);
        randomSet.parent = pasifSetler;
        randomSet.localPosition = pasifSetler.GetChild(0).localPosition;
        
    }
    IEnumerator CheckForVisibilty()
    {
        while (true)
        {
            yield return new WaitForEndOfFrame();
            if (aktifSetler.GetChild(0).GetChild(1).GetComponent<SpriteRenderer>().isVisible == false)
            {
                Recycle();

            }
        }
    }
    IEnumerator Move()
    {
        while (true)
        {
            
            Camera.main.transform.Translate(Vector2.up*KarakterHiz*Time.deltaTime);
            yield return null;
        }
    }
}
