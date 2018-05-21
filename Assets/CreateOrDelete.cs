﻿using UnityEngine;
using UnityEngine.UI;

public class CreateOrDelete : MonoBehaviour
{

	public Button Create;
	public Button Delete;
	public bool IsInCreateState;

	private void Start()
	{
		IsInCreateState = true;
		Delete.image.color = Color.white;
		Create.image.color = Color.gray;
	}

	public void CreateModel()
	{
		IsInCreateState = true;
		Delete.image.color = Color.white;
		Create.image.color = Color.gray;
	}

	public void DelteModel()
	{
		IsInCreateState = false;
		Delete.image.color = Color.gray;
		Create.image.color = Color.white;
	}
	
}
