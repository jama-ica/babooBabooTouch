using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyColor {

	protected int r;
	protected int g;
	protected int b;
	protected int a;

	public MyColor()
		: this(0, 0, 0, 255)
	{
	}

	public MyColor(int r, int g, int b)
		: this(r, g, b, 255)
	{
	}

	public MyColor(int r, int g, int b, int a)
	{
		this.r = r;
		this.g = g;
		this.b = b;
		this.a = 255;
	}

	public void setColor(int r, int g, int b, int a)
	{
		this.r = r;
		this.g = g;
		this.b = b;
		this.a = a;
	}

	public void setColor(int r, int g, int b)
	{
		this.setColor(r, g, b, 255);
	}

	public Color createColor(int r, int g, int b, int a)
	{
		this.setColor(r, g, b, a);
		return createColor();
	}

	public Color createColor(int r, int g, int b)
	{
		return createColor(r, g, b, 255);
	}

	public Color createColor()
	{
		float r = this.r / 255.0f;
		float g = this.g / 255.0f;
		float b = this.b / 255.0f;
		float a = this.a / 255.0f;
		return new Color(r, g, b, a);
	}

}
