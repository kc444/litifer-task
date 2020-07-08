using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WAVESCRIPT : MonoBehaviour
{   

    public GameObject i1;
    public GameObject i2;
    public GameObject i3;
    public GameObject i4;
    public GameObject i5;
    public GameObject i6;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(i1, 10, 3).setEaseInOutCubic().setLoopPingPong();
        LeanTween.moveY(i2, 10, 4).setEaseInOutCubic().setLoopPingPong();
        LeanTween.moveY(i3, 10, 5).setEaseInOutCubic().setLoopPingPong();
        LeanTween.moveY(i4, 10, 6).setEaseInOutCubic().setLoopPingPong();
        LeanTween.moveY(i5, 10, 7).setEaseInOutCubic().setLoopPingPong();
        LeanTween.moveY(i6, 10, 8).setEaseInOutCubic().setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
