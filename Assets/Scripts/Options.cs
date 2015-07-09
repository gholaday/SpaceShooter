﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Options : MonoBehaviour {

	public static float musicMuteFactor = 1;
	public static float sfxMuteFactor = 1;
	public static float musicVolumeFactor = 1;
	public static float sfxVolumeFactor = 1;
	
	public Scrollbar musicVol;
	public Scrollbar sfxVol;
	
	public Toggle muteMusic;
	public Toggle muteSfx;
	
	void Update()
	{
		UpdateOptions ();
	}
	
	void UpdateOptions()
	{
		musicVolumeFactor = musicVol.value;
		sfxVolumeFactor = sfxVol.value;
		
		musicMuteFactor = muteMusic.isOn ? 1 : 0;
		sfxMuteFactor = muteSfx.isOn ? 1 : 0;
	}
}
