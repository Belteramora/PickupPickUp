using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsPlacePoint : MonoBehaviour
{
    private int currentPP;

    [SerializeField]
    private float placeAnimTime;

    [SerializeField]
    private Transform[] placePoints;

    public void PlaceObject(Transform obj)
    {
        if (currentPP >= placePoints.Length) return;

        obj.SetParent(placePoints[currentPP]);

        obj.DOLocalMove(Vector3.zero, placeAnimTime);
        obj.DOLocalRotate(obj.GetComponent<Interactable>().onPlaceCorrectRotation, placeAnimTime);

        currentPP++;
    }
}
