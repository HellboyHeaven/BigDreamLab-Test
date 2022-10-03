using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ExtinorInteractable : XRGrabInteractable
{
    [SerializeField] private Handle _handle;

    protected override void OnActivated(ActivateEventArgs args)
    {
        if (_handle.CanShot == true)
        {
            base.OnActivated(args);
        }
        
    }


    private void MathAttachPoint(XRBaseInteractor interactor)
    {
        bool isDirect = interactor is XRDirectInteractor;
        attachTransform.position = isDirect ? interactor.attachTransform.position : transform.position;
        attachTransform.rotation = isDirect ? interactor.attachTransform.rotation : transform.rotation;
    }

    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        base.OnSelectEntering(args);
        MathAttachPoint(args.interactor);
    }

}
