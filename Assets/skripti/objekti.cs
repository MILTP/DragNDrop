using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject baltaMasina;
	public GameObject cementaMasina;
	public GameObject BMW;
	public GameObject eskavators;
	public GameObject audi;
	public GameObject policija;
	public GameObject traktors;
	public GameObject ugunsdzesejs;
	public GameObject traktors1;


	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atraPKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 baltaMKoord;
	[HideInInspector]
	public Vector2 cementaKoord;
	[HideInInspector]
	public Vector2 BMWKoord;
	[HideInInspector]
	public Vector2 audiKoord;
	[HideInInspector]
	public Vector2 eskavatorsKoord;
	[HideInInspector]
	public Vector2 policijaKoord;
	[HideInInspector]
	public Vector2 traktorsKoord;
	[HideInInspector]
	public Vector2 ugunsdzesejsKoord;
	[HideInInspector]
	public Vector2 traktors1Koord;

	public Canvas kanva;

	public AudioSource audioAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;

	public GameObject Stars;
	public GameObject Menu;
	public GameObject SpendTime;
	public GameObject ResetButton;
	public int NStars = 1;
	public int AcceptedCars;
	public Sprite[] MenuGroupStars;

	public Text text;
	public int h;
	public int m;
	public int s;
	public float ms;

	void Start () {
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		atraPKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		bussKoord = autobuss.GetComponent<RectTransform> ().localPosition;
		baltaMKoord = baltaMasina.GetComponent<RectTransform> ().localPosition;
		cementaKoord = cementaMasina.GetComponent<RectTransform> ().localPosition;
		BMWKoord = BMW.GetComponent<RectTransform> ().localPosition;
		audiKoord = audi.GetComponent<RectTransform> ().localPosition;
		eskavatorsKoord = eskavators.GetComponent<RectTransform> ().localPosition;
		policijaKoord = policija.GetComponent<RectTransform> ().localPosition;
		traktorsKoord = traktors.GetComponent<RectTransform> ().localPosition;
		ugunsdzesejsKoord = ugunsdzesejs.GetComponent<RectTransform> ().localPosition;
		traktors1Koord = traktors1.GetComponent<RectTransform> ().localPosition;
	}

	public void Timer(){
		if (AcceptedCars < 12) {
			ms += 0.02f;
		}
		if (ms >= 1) {
			s++;
			ms = 0;
		}
		if (s >= 60) {
			m++;
			s = 0;
		}
		if (m >= 60) {
			h++;
			m = 0;
		}
		text.text = "{h} : {m} : {s}";
		switch (m) {
		case 0:
			NStars = 2;
			break;
		case 1:
			NStars = 1;
			break;
		case 2:
			NStars = 0;
			break;
		}
		if (h > 0) {
			NStars = 0;
		}
	}
	public void Score(){
		if (AcceptedCars >= 12) {
			Stars.SetActive (true);
			ResetButton.SetActive (true);
			Menu.SetActive (true);
			SpendTime.SetActive (true);
			switch (NStars) {
			case 0:
				Stars.GetComponent<Image>().sprite = MenuGroupStars [0];
				break;
			case 1:
				Stars.GetComponent<Image>().sprite = MenuGroupStars [1];
				break;
			case 2:
				Stars.GetComponent<Image>().sprite = MenuGroupStars [2];
				break;
			}
		}
	}

	public void Reset(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
	}

}
