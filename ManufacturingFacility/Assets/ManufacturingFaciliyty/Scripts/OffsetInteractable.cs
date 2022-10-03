using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OffsetInteractable : XRGrabInteractable
{
    public Quaternion Rotation { get; private set; }
    
    [SerializeField] private Material _selectedMaterial;
    [SerializeField] private Material _hoveredMaterial;
    [SerializeField] private Material _activatedMaterial;
    [Header("Constraints")]
    [SerializeField] private bool _rotationX;
    [SerializeField] private bool _rotationY;
    [SerializeField] private bool _rotationZ;

    private Quaternion _rotation;

    private Material _originalMaterial;
    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _originalMaterial = _renderer.material;
        _rotation = transform.rotation;
    }
    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        base.OnSelectEntering(args);
        MathAttachPoint(args.interactor);
        //RotationConstrain();
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        _renderer.material = _selectedMaterial ? _selectedMaterial : _originalMaterial;
    }
    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        _renderer.material = _hoveredMaterial ? _hoveredMaterial : _originalMaterial;

    }
    protected override void OnActivated(ActivateEventArgs args)
    {
        base.OnActivated(args);
        _renderer.material = _activatedMaterial ? _activatedMaterial : _originalMaterial;
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        _renderer.material = _originalMaterial;
        
    }
    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);
        _renderer.material = _originalMaterial;
    }

    protected override void OnDeactivated(DeactivateEventArgs args)
    {
        base.OnDeactivated(args);
        _renderer.material = _originalMaterial;
    }

    private void MathAttachPoint(XRBaseInteractor interactor)
    {
        bool isDirect = interactor is XRDirectInteractor;
        attachTransform.position = isDirect ? interactor.attachTransform.position : transform.position;
        attachTransform.rotation = isDirect ? interactor.attachTransform.rotation : transform.rotation;
    }
    private void RotationConstrain()
    {
        transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}
