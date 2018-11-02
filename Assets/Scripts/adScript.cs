using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class adScript : MonoBehaviour {
    
    // Use this for initialization
    void Start()
    {
        RequestBanner();
    }

    

   private void RequestBanner()
	{
        
        string adUnitId = "ca-app-pub-7518596638689711/1265196357";


        // Create banner at the bottom of the screen.
        BannerView bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        
		// Load the banner with the request.
		bannerView.LoadAd(request);
        
	}
	
	
}