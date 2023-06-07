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

	public GameObject restartButton;
	public GameObject endGameMenu;
	public GameObject text;
	public int NCars = 0;
	private float timeP;
	public GameObject star1;
	public GameObject star2;
	public GameObject star3;

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
		timeP = Time.time;//taimers uzsāc darbu
		Screen.SetResolution(1280, 600, false);
	}

	public void FInalResults() {
		if (NCars >= 12) { //Ja pareizo mašinu vietās
			endGameMenu.SetActive(true); //Parādās menu
			restartButton.SetActive(true); //Paradas spēles restart poga
			text.SetActive(true); //Parādās tekst ar laiku
			float cikLaiks = Time.time - timeP; //cikLaiks satur laiku no Start metoda līdz pēdējas mašinas salikšanai
			int stundas = (int) cikLaiks / 3600; //cik stundas
			int minutes = (int) (cikLaiks%3600) / 60; //cik minutes
			int sekundes = (int) (cikLaiks%3600) % 60; //cik sekundes 
			string laiks = string.Format("{0:00}:{1:00}:{2:00}", stundas, minutes, sekundes); //Formatejam hh:mm:ss formatā
			string str = "Tavs rezultats: \n" + laiks; //teksta saglabāšana
			text.GetComponent<Text>().text = str; //teksts glabasies teksta lodziņā
			if (minutes<2) //ja spēles laiks neparsniedz 2 min
			{
				star1.SetActive(true); //paradas tris zvaigznes
				star2.SetActive(true);
				star3.SetActive(true);
			}else if(minutes<3) //ja spele neparsniedz 3 min 
			{
				star1.SetActive(true); //paradas divas zvaigznes
				star2.SetActive(true);
			}
			else //ja spele parsniedz tris minutes
			{
				star1.SetActive(true); //paradas viena zvaigzne
			}
		}
	}
}
