﻿/*
using UnityEngine;
using System.Collections;

public class soundbtn : MenuButtonClass
{
    public GameObject soundoff;
    public GameObject sound;
    public bool dzwiekwlacz = false;

    // Use this for initialization
    void Start()
    {
        int cos = PlayerPrefs.GetInt("soundset", 0);
        sound.SetActive(true);

        if (cos == 0)
        {
            soundoff.SetActive(false);
        }
        else
        {
            soundoff.SetActive(true);
            AudioListener.pause = true;
        }
    }

    void Update()
    {
    }

    //public void soundbutton()
    public override void OnMouseDown()
    {
        base.OnMouseDown();
        if (dzwiekwlacz == false)
        {
            Debug.Log("sound on");
            dzwiekwlacz = true;
            soundoff.SetActive(true);
            AudioListener.pause = true;
            PlayerPrefs.SetInt("soundset", 1);

        }
        else
        {
            Debug.Log("sound off");
            dzwiekwlacz = false;
            AudioListener.pause = false;
            soundoff.SetActive(false);
            PlayerPrefs.SetInt("soundset", 0);
        }
    }
}
*/
