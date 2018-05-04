using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	private List<MyColor> colorList = new List<MyColor>();
	private int colorIndex = 0;


    // Use this for initialization
    void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		GameObject obj = getClickObject();
		if (obj == this.gameObject)
		{
            this.addColorIndex(1);
			this.updateColor();
		}
	}

	public void updateColor()
	{
		this.GetComponent<SpriteRenderer>().color = createColor();
	}

	public void setColorList(List<MyColor> colorList)
	{
        this.colorList = new List<MyColor>();
        this.colorList.Add(new MyColor(255, 0, 0));
        this.colorList.Add(new MyColor(0, 255, 0));
        this.colorList.Add(new MyColor(0, 0, 255));
        //this.colorList = colorList;
	}

	public void addColorList(MyColor myColor)
	{
		this.colorList.Add(myColor);
	}

	public void setColorIndex(int index)
	{
		this.colorIndex = index;
	}

	protected void addColorIndex(int add = 1)
	{
		this.colorIndex+=1;
		if(this.colorIndex >= this.colorList.Count)
		{
			this.colorIndex = 0;
		}
	}

	protected Color createColor()
	{
		if (this.colorIndex >= this.colorList.Count)
		{
			return new Color(0.0f, 0.0f, 0.0f, 255.0f);
		}
		return this.colorList[this.colorIndex].createColor();
	}

	// 左クリックしたオブジェクトを取得する関数(2D)
	private GameObject getClickObject()
	{
		GameObject result = null;
		// 左クリックされた場所のオブジェクトを取得
		if (Input.GetMouseButtonDown(0))
		{
			Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D collition2d = Physics2D.OverlapPoint(tapPoint);
			if (collition2d)
			{
				result = collition2d.transform.gameObject;
			}
		}
		return result;
	}
}
