using UnityEngine;
using System.Collections;
using Prime31;

public class ads : MonoBehaviour
{

    public static ads Instance;
    public void Awake()
    {
        Instance = this;
        
    }

    /// <summary>
    ///请求 展示顶部横幅广告 运行该方法会直接展示广告
    /// </summary>
    public void CreateBanner()
    {
        
        //横幅广告
        AdMobAndroid.createBanner("ca-app-pub-2074038887353115/6452126981", AdMobAndroidAd.phone320x50, AdMobAdPlacement.TopCenter);
    }
    //显示横幅广告
    public void ShowBanner()
    {
        AdMobAndroid.hideBanner(false);
    }
    /// <summary>
    /// 请求全屏广告 使用全屏广告之前必须先请求
    /// </summary>
    public void RequestInterstital()
    {
        //传入谷歌全屏广告码  插页广告ca-app-pub-2074038887353115/9301724989
        AdMobAndroid.requestInterstital("ca-app-pub-2074038887353115/9301724989");
    }
    public void ShowInterstital()
    {
        var isReady = AdMobAndroid.isInterstitalReady();
        if (isReady)
        {
            AdMobAndroid.displayInterstital();
        }
        else
        {
            //如果全屏广告没有准备好  就请求下 方便下次展示
            RequestInterstital();
        }
    }

}
