using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject AlarmUI;

    public Vector3 TargetVector;

    public Vector3 TargetPosition;

    public Vector3 TargetRotation;

    public float dur;

    public float fadeduration;

    public float Timetransform;

    public float MoveSpeed;

    public Image image_1;

    private void Start()
    {

    }

    /*public void ResizeDown()
    {
        AlarmUI.transform.DOScale(TargetVector, Timetransform).SetEase(Ease.InOutElastic);
    }

    public void ChangePosition()
    {
        AlarmUI.transform.DOMove(TargetPosition, MoveSpeed).OnComplete(()=>ResizeDown());
    }

    public void Rotate()
    {
        image_1.transform.DOLocalRotate(TargetRotation, dur).SetEase(Ease.Linear).SetLoops(-1,LoopType.Incremental);
    }*/

    /*public void fade()
    {
        image_1.DOFade(0, fadeduration);
    }*/

    public void transitions()
    {
        Sequence sequence = DOTween.Sequence();

        //first task in the sequence
        sequence.Append(image_1.transform.DOMoveX(-40, 2f));
        //delay
        sequence.AppendInterval(1);
        //second task in the sequence
        sequence.Append(image_1.transform.DOLocalRotate(TargetRotation, 2).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental));
        //delay for 2nd task
        sequence.AppendInterval(1);
        //third task in the sequence
        sequence.Append(image_1.DOFade(0, 2f));
    }

}
