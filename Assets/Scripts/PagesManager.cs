using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;

public class PagesManager : MonoBehaviour
{
	[SerializeField]
	private GameObject _scrollPrefab;
	[SerializeField]
	private Canvas _canvas;
	[SerializeField]
	private AppInfoGenerator _appInfoGenerator;
	

	private GameObject _currentScroll;

	private void Start()
	{
		InstantiatePage();
	}

	private void Update()
	{
		
	}

	private void InstantiatePage()
	{
		_currentScroll = Instantiate(_scrollPrefab, _canvas.transform);
		Pages page = _currentScroll.GetComponent<Pages>();
		page.SubscribeOnPageChange(OnCurrentPageChanged);
		page.SetPageInfo(_appInfoGenerator.Generate());
	}
	private void OnCurrentPageChanged(int page)
	{
		Destroy(_currentScroll);
		InstantiatePage();
		if(page == 0)
		{
			Debug.Log("Declined");
		}
		if(page == 2)
		{
			Debug.Log("Accepted");
		}
	}
}
