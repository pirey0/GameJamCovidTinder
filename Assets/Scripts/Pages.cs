using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pages : MonoBehaviour
{
	[SerializeField] private Text _title;
	[SerializeField] private Text _description;
	[SerializeField] private Image _logo;
	private void Start()
	{

	}

	public void SetPageInfo(Image logo,Text title, Text description)
	{
		_title = title;
		_description = description;
		_logo = logo;
	}
}
