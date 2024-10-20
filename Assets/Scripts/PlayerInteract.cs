using Cinemachine;
using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;

    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private LayerMask interactionMask;
    [SerializeField]
    private float pickAnimationTime;
    [SerializeField]
    private Transform holdPoint;

    private PlayerUI playerUI;
    private InputManager inputManager;


    private Transform holdedObject;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        playerUI.UpdateText(string.Empty);

        Ray ray = new Ray(cam.transform.position, cam.transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hitInfo, distance, interactionMask)) 
        {
            var interactable = hitInfo.collider.GetComponent<Interactable>();

            if (interactable != null)
            {
                playerUI.UpdateText(interactable.promptMessage);

                if (inputManager.onFoot.Interact.triggered)
                {
                    switch (interactable.interactType)
                    {
                        case InteractType.Pick:
                            if (holdedObject != null) return;
                            holdedObject = interactable.transform;
                            holdedObject.SetParent(holdPoint);
                            holdedObject.DOLocalMove(Vector3.zero, pickAnimationTime);
                            holdedObject.DOLocalRotate(interactable.onPickCorrectRotation, pickAnimationTime);
                            break;
                        case InteractType.Place:

                            if (holdedObject == null) return;

                            interactable.GetComponent<ObjectsPlacePoint>().PlaceObject(holdedObject);

                            holdedObject = null;
                            break;
                    }
                }
            }
        }
    }
}
