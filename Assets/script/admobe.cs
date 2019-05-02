// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using GoogleMobileAds.Api;

// public class admobe : MonoBehaviour {

    // public RewardBasedVideoAd rewardBasedVideo;

    // private static bool created = false;

    // public static admobe instance;

    // private InterstitialAd interstitial;

    // public BannerView bannerView;

    // void Start()
    // {

    //     if (instance == null) {
	// 		instance = this;
	// 	}

    //     #if UNITY_ANDROID
    //         string appId = "ca-app-pub-8456654241707450~2993084991";
    //     #else
    //         string appId = "unexpected_platform";
    //     #endif

    //     // Initialize the Google Mobile Ads SDK.
    //     MobileAds.Initialize(appId);

    //     this.RequestBanner();
    //     this.RequestInterstitial();
    // }

    // public void RequestBanner()
    // {
    //     #if UNITY_ANDROID
    //         // string adUnitId = "ca-app-pub-3940256099942544/6300978111";
    //         string adUnitId = "ca-app-pub-8456654241707450/6890578348";
    //         //                               
    //     #else
    //         string adUnitId = "unexpected_platform";
    //     #endif

    //     // Clean up banner ad before creating a new one.
    //     if (this.bannerView != null)
    //     {
    //         this.bannerView.Destroy();
    //     }

    //     // Create a 320x50 banner at the top of the screen.
    //     bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

    //     // Create an empty ad request.
    //     AdRequest request = new AdRequest.Builder().Build();

    //     // Load the banner with the request.
    //     bannerView.LoadAd(request);
    // }

    // public void RequestInterstitial(){
    //     #if UNITY_ANDROID
    //         string adUnitId = "ca-app-pub-8456654241707450/1411020951";
    //     #else
    //         string adUnitId = "unexpected_platform";
    //     #endif

    //     // Initialize an InterstitialAd.
    //     this.interstitial = new InterstitialAd(adUnitId);
    //     // Create an empty ad request.
    //     AdRequest request = new AdRequest.Builder().Build();
    //     // Load the interstitial with the request.
    //     this.interstitial.LoadAd(request);
    // }

    // public void GameOver(){
    // if (this.interstitial.IsLoaded()) {
    //     this.interstitial.Show();
    // }
    // }

// }