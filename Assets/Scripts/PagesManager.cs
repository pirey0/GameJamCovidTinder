using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;

public class PagesManager : MonoBehaviour
{
	[SerializeField]
	private ScrollSnapBase _scrollSnapBase;
	[SerializeField]
	private Canvas _canvas;


	private ScrollSnapBase _currentScroll;
	private void Start()
	{
		InstantiateMatch();
	}

	private void InstantiateMatch()
	{

		_currentScroll = Instantiate(_scrollSnapBase, _canvas.transform);
	}
}
