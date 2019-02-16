using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;
using UnityEngine;

public class ADDDS : MonoBehaviour
{

    public void Showads()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo", new ShowOptions()
            {
                resultCallback = HandleAdResult
            });
        }

    }
    private void HandleAdResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("Player Gains +50 Points");
                break;
            case ShowResult.Skipped:
                Debug.Log("Player Did not fully watch the Ads");
                break;
            case ShowResult.Failed:
                Debug.Log("Player failed to launch the ad ?");
                break;
        }
    }
}
