using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenAnimation : MonoBehaviour
{
    public float animationTime;
    // Start is called before the first frame update
    void Start()
    {
        var seq = DOTween.Sequence();

        seq.Append(transform.DOLocalMoveY( 2.517f, animationTime));
        seq.Join(transform.DOScaleY(0.2f, animationTime));

        seq.Play();
    }
}
