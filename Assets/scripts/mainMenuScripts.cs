﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuScripts : MonoBehaviour {

	public void play()
    {
        Application.LoadLevel(1);

    }

    public void quit()
    {
        Application.Quit();
    }
}
