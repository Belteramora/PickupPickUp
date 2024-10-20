using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public InteractType interactType;

    public Vector3 onPickCorrectRotation;
    public Vector3 onPlaceCorrectRotation;

    //����������� ����� ������������ ��� ��������� �� ������
    public string promptMessage;
}

public enum InteractType
{
    Pick,
    Place
}
