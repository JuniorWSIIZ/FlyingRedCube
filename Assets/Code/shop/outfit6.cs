﻿using UnityEngine;
using System.Collections;

public class outfit6 : MonoBehaviour
{

    public GameObject EM;
    public GameObject owned5;

    public bool of6 = false;

    //set
    public GameObject set1;
    public GameObject set2;
    public GameObject set3;
    public GameObject set4;
    public GameObject set5;
    public GameObject set6;


    // Use this for initialization
    void Start()
    {
        int zestaw6 = PlayerPrefs.GetInt("outfit6", 0);
        if (zestaw6 == 1)
        {
            owned5.SetActive(true);
        }
        int zestawustawiony6 = PlayerPrefs.GetInt("outfit6", 0);
        if (zestawustawiony6 == 1)
        {
            set1.SetActive(false);
            PlayerPrefs.SetInt("setoutfit1", 0);
            set2.SetActive(false);
            PlayerPrefs.SetInt("setoutfit2", 0);
            set3.SetActive(false);
            PlayerPrefs.SetInt("setoutfit3", 0);
            set4.SetActive(false);
            PlayerPrefs.SetInt("setoutfit4", 0);
            set5.SetActive(false);
            PlayerPrefs.SetInt("setoutfit5", 0);
            set6.SetActive(true);
            PlayerPrefs.SetInt("setoutfit6", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        int zestaw6 = PlayerPrefs.GetInt("outfit6", 0);
        if (zestaw6 == 0)
        {

            // Zakup
            if (PlayerPrefs.GetInt("punktacja") < 3000)
            {
                EM.SetActive(true);
            }

            if (PlayerPrefs.GetInt("punktacja") >= 3000)
            {
                int x = PlayerPrefs.GetInt("punktacja", 0) - 3000;
                PlayerPrefs.SetInt("punktacja", x);
                Debug.Log("Stan konta -" + x + "punktów");

                // Po zakupie ustawienie outfitu
                Debug.Log("Outfit zakupiony!");
                PlayerPrefs.SetInt("outfit6", 1);
                owned5.SetActive(true);
            }
        }
        else
        {
            // Ustawienie zalozenia elemetu
            if (zestaw6 == 1)
            {
                set1.SetActive(false);
                PlayerPrefs.SetInt("setoutfit1", 0);
                set2.SetActive(false);
                PlayerPrefs.SetInt("setoutfit2", 0);
                set3.SetActive(false);
                PlayerPrefs.SetInt("setoutfit3", 0);
                set4.SetActive(false);
                PlayerPrefs.SetInt("setoutfit4", 0);
                set5.SetActive(false);
                PlayerPrefs.SetInt("setoutfit5", 0);
                set6.SetActive(true);
                PlayerPrefs.SetInt("setoutfit6", 1);
            }
        }
    }
}