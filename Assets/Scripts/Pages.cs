using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class Pages : MonoBehaviour
{
	[SerializeField] private Text _title;
	[SerializeField] private Text _description;
	[SerializeField] private Image _logo;

	[SerializeField] private ScrollSnapBase _scrollSnapBase;


	private void Start()
	{

	}

	public void SetPageInfo(AppInfo appinfo)
	{
		AppInfo name = appinfo;
		_title.text = name.Title;
		//_logo.sprite = name.Logo;
		_description.text = name.Description;
	}

	public void SubscribeOnPageChange(UnityEngine.Events.UnityAction<int> action)
	{
		_scrollSnapBase.OnSelectionChangeEndEvent.AddListener(action);
	}

}
