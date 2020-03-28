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

    [SerializeField] private int scoreOnCorrect = 100, scoreOnWrong = -500;

    int score = 0;

	private Pages _currentPage;

	private void Start()
	{
		InstantiatePage();
	}

	private void InstantiatePage()
	{
		var go = Instantiate(_scrollPrefab, _canvas.transform);
        _currentPage = go.GetComponent<Pages>();
        _currentPage.SubscribeOnPageChange(OnCurrentPageChanged);
        _currentPage.SetPageInfo(_appInfoGenerator.Generate());
        _currentPage.SetScore(score);
	}
	private void OnCurrentPageChanged(int page)
	{
        bool isCoronaRelated = _currentPage.Info.IsCoronaRelated;
        bool declined = page == 0;

		if(declined)
		{
			Debug.Log("Declined");
        }
        else
        {
			Debug.Log("Accepted");
		}

        if(isCoronaRelated ^ declined)
        {
            score += scoreOnWrong;
            score = Mathf.Max(0, score);
        }
        else
        {
            score += scoreOnCorrect;
        }

        Destroy(_currentPage.gameObject);
        InstantiatePage();
    }
}
