using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matching : MonoBehaviour
{
	private PopulateScrollSnap _populateScrollSnap;
	private void Update()
	{
		//have inputs of hotkeys here
	}
	private void MatchFound()
	{
		_populateScrollSnap.AddSlider();
	}
	private void MatchSkipped()
	{
		_populateScrollSnap.AddSlider();
	}
}
