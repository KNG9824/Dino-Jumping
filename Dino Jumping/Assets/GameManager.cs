using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Level(int score)
    {
        int defaultspeed = -5;
        int increspeed = (score * -1) / 100;
        if (increspeed < -5)
        {
             increspeed = -5;
        }
        return defaultspeed + increspeed;
    }
    }
