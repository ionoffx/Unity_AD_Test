﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADManager : MonoBehaviour
{
    public ADManager instance;

    // Start is called before the first frame update
    void Start()
    {

        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void unityAdsOn()
    {
        UnityAds.instance.ShowRewardedAd();
    }

}
