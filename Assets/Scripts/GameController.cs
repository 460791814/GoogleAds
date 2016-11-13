using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	//游戏开始就加载广告
        ads.Instance.CreateBanner();
        ads.Instance.RequestInterstital();
     
	}

    void OnGUI()
    {
        if (GUILayout.Button("游戏暂停"))
        {
            //展示全屏广告
            ads.Instance.ShowInterstital();
        }
    }
}
