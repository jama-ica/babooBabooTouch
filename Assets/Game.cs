using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	public NewBehaviourScript myCube;

	// Use this for initialization
	void Start () {
        NewBehaviourScript cube = Instantiate(myCube, transform.position, transform.rotation);
        List<MyColor> colorList = new List<MyColor>();
        colorList.Add(new MyColor(255, 0, 0));
        colorList.Add(new MyColor(0, 255, 0));
        colorList.Add(new MyColor(0, 0, 255));
        cube.setColorList(colorList);
        cube.setColorIndex(0);
        cube.updateColor();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
