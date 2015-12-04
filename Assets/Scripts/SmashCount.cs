using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SmashCount : MonoBehaviour 
{
	public int smashcount;
	public int NumberPerSmashes;
	public Text CountText;

	void start()
	{	
		smashcount = 0;
		CountText.text = "smash number: " + smashcount.ToString ();
	}

	void SmashNumber()
	{
		smashcount = smashcount + NumberPerSmashes;
		CountText.text = "smash number: " + smashcount.ToString ();
	}

}
