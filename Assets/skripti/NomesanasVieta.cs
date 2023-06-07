using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Runtime.Serialization;

public class NomesanasVieta : MonoBehaviour, IDropHandler  {
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public objekti objektuSkripts;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null) {
            if (eventData.pointerDrag.tag.Equals(tag)) {
                vietasZRot =
                GetComponent<RectTransform>().transform.eulerAngles.z;

                velkObjZRot =
                eventData.pointerDrag.GetComponent<RectTransform>().
                transform.eulerAngles.z;

                rotacijasStarpiba = Mathf.Abs(velkObjZRot - vietasZRot);

                velkObjIzm = eventData.pointerDrag.
                    GetComponent<RectTransform>().localScale;
               
                vietasIzm = GetComponent<RectTransform>().localScale;

                xIzmeruStarp = Mathf.Abs(velkObjIzm.x - vietasIzm.x);
                yIzmeruStarp = Mathf.Abs(velkObjIzm.y - vietasIzm.y);

                if ((rotacijasStarpiba <= 6 || 
                    (rotacijasStarpiba >= 354 && rotacijasStarpiba<=360))
                    && (xIzmeruStarp<= 0.1 && yIzmeruStarp <=0.1)) {
                    
                    objektuSkripts.vaiIstajaVieta = true;
                    
                    eventData.pointerDrag.GetComponent<RectTransform>()
                        .anchoredPosition =
                        GetComponent<RectTransform>().anchoredPosition;

                    eventData.pointerDrag.GetComponent<RectTransform>()
                        .localRotation = 
                        GetComponent<RectTransform>().localRotation;

                    eventData.pointerDrag.GetComponent<RectTransform>()
                        .localScale = 
        				GetComponent<RectTransform>().localScale;
					objektuSkripts.NCars++;//uzglaba vienu mašinu par īstā vietā novietošanu
					objektuSkripts.FInalResults();//metode ar laiku, skaitu
                    switch(eventData.pointerDrag.tag)
                    {
                        case "atkritumi":
                            objektuSkripts.audioAvots.
                            PlayOneShot(objektuSkripts.skanasKoAtskanot[1]);
                            break;

                        case "medicina":
                            objektuSkripts.audioAvots.
                            PlayOneShot(objektuSkripts.skanasKoAtskanot[2]);
                            break;

                        case "buss":
                            objektuSkripts.audioAvots.
                            PlayOneShot(objektuSkripts.skanasKoAtskanot[3]);
                            break;

						case "balts":
							objektuSkripts.audioAvots.
							PlayOneShot(objektuSkripts.skanasKoAtskanot[4]);
							break;

						case "cements":
							objektuSkripts.audioAvots.
							PlayOneShot(objektuSkripts.skanasKoAtskanot[5]);
							break;

						case "bmw":
							objektuSkripts.audioAvots.
							PlayOneShot(objektuSkripts.skanasKoAtskanot[6]);
							break;

						case "audi":
							objektuSkripts.audioAvots.
							PlayOneShot(objektuSkripts.skanasKoAtskanot[7]);
							break;

						case "eskavators":
							objektuSkripts.audioAvots.
							PlayOneShot(objektuSkripts.skanasKoAtskanot[8]);
							break;

						case "policija":
							objektuSkripts.audioAvots.
							PlayOneShot(objektuSkripts.skanasKoAtskanot[9]);
							break;

						case "traktors":
							objektuSkripts.audioAvots.
							PlayOneShot(objektuSkripts.skanasKoAtskanot[10]);
							break;

						case "ugunsdzesejs":
							objektuSkripts.audioAvots.
							PlayOneShot(objektuSkripts.skanasKoAtskanot[11]);
							break;

						case "traktors1":
							objektuSkripts.audioAvots.
							PlayOneShot(objektuSkripts.skanasKoAtskanot[12]);
							break;

                    }
                }
               
            } else {
                objektuSkripts.vaiIstajaVieta = false;
                objektuSkripts.audioAvots.
                 PlayOneShot(objektuSkripts.skanasKoAtskanot[0]);
                
                switch (eventData.pointerDrag.tag){
                    case "atkritumi":
                        objektuSkripts.atkritumuMasina.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.atkrMKoord;
                        break;

                    case "medicina":
                        objektuSkripts.atraPalidziba.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.atraPKoord;
                        break;

                    case "buss":
                        objektuSkripts.autobuss.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.bussKoord;
                        break;

					case "balts":
						objektuSkripts.baltaMasina.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.baltaMKoord;
						break;

					case "cements":
						objektuSkripts.cementaMasina.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.cementaKoord;
						break;

					case "bmw":
						objektuSkripts.BMW.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.BMWKoord;
						break;

					case "audi":
					objektuSkripts.audi.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.audiKoord;
						break;

					case "eskavators":
						objektuSkripts.eskavators.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.eskavatorsKoord;
						break;

					case "policija":
						objektuSkripts.policija.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.policijaKoord;
						break;

					case "traktors":
						objektuSkripts.traktors.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.traktorsKoord;
						break;

					case "ugunsdzesejs":
						objektuSkripts.ugunsdzesejs.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.ugunsdzesejsKoord;
						break;

					case "traktors1":
						objektuSkripts.traktors1.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.traktors1Koord;
						break;
                }
            }
        }
    }
}
