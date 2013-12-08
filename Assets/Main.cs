using UnityEngine;
using System.Collections;

/**
 * cocos2d-x Box2Dのサンプル
 *
 */
public class Main : MonoBehaviour
{
	public GameObject cube;

	public Sprite a;
	public Sprite b;
	public Sprite c;
	public Sprite d;

	private int count;

	void Awake()
	{
		Application.targetFrameRate = 60;
	}

	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetMouseButtonDown(0)){
			GameObject go = Resources.Load("cube") as GameObject;

			int num = Random.Range(0,4);
			
			Sprite s;
			switch(num){
				case 0:  s=a; break;
				case 1:  s=b; break;
				case 2:  s=c; break;
				default: s=d; break;
			}
			go.GetComponent<SpriteRenderer>().sprite = s;

			Vector3 p = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			Instantiate(go,new Vector3(p.x,p.y,0.0f),Quaternion.identity);

			//GameObject go = Instantiate(this.cube) as GameObject;
			count++;
			UnityEngine.Debug.Log("count:"+count);
		}
	}
}
