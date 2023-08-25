using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Buttons : MonoBehaviour
{
    public GameObject AlarmUI;

    public Vector3 TargetVector;

    public Vector3 TargetPosition;

    public float Timetransform;

    public float MoveSpeed;

    public void ResizeDown()
    {
        AlarmUI.transform.DOScale(TargetVector, Timetransform).SetEase(Ease.InOutElastic);
    }

    public void ChangePosition()
    {
        AlarmUI.transform.DOMove(TargetPosition, MoveSpeed).OnComplete(()=>ResizeDown());
    }
}
