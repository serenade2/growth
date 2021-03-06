﻿using UnityEngine;
using System.Collections;

public class FaceUpdate2 : MonoBehaviour
{
    public AnimationClip[] animations;

    Animator anim;

    public float delayWeight;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Uncomment the following line to display on the screen all the face animations that is  available on the game screen.
    /*void OnGUI()
    {
        foreach (var animation in animations)
        {
            if (GUILayout.Button(animation.name))
            {
                anim.CrossFade(animation.name, 0);
            }
        }
    }*/

    float current = 0;


    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            current = 1;
        }
        else
        {
            current = Mathf.Lerp(current, 0, delayWeight);
        }
        anim.SetLayerWeight(1, current);
    }
}
