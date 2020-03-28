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
    [SerializeField] private Text _score;

	[SerializeField] private ScrollSnapBase _scrollSnapBase;

    AppInfo info;

    public AppInfo Info { get => info; }

	public void SetPageInfo(AppInfo appinfo)
	{
        info = appinfo;

		_title.text = info.Title;
		_logo.sprite = info.Logo;
		_description.text = info.Description;
	}

    public void SetScore(int score)
    {
        _score.text = score.ToString();
    }

	public void SubscribeOnPageChange(UnityEngine.Events.UnityAction<int> action)
	{
		_scrollSnapBase.OnSelectionChangeEndEvent.AddListener(action);
	}

}
