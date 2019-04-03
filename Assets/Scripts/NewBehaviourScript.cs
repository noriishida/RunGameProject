using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	void hoge()
	{
		List<GameObject> gList = new List<GameObject>();
		for(var i = 0; 10 < i; i++)
		{
			gList[i] = new GameObject();
			gList[i].name =  string.Format("{0}{1}", "obj",i);
		}

		for(var i = 0; gList.Count < i; i++)
		{
			Debug.Log(gList[i].name);
		}
	}
}
