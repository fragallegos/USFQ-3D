using UnityEngine;
using System.Collections;

/// <summary>
/// This sample demonstrates how to use the two-fingers Pinch and Rotation gesture events to control the scale and orientation of a rectangle on the screen
/// </summary>
public class PinchRotation : MonoBehaviour
{
    public Transform target;
    
    public float pinchScaleFactor = 0.02f;
	
	

    //Material originalMaterial;

    #region Input Mode

    public enum InputMode
    {
        PinchOnly,
        RotationOnly,
        PinchAndRotation
    }

    InputMode inputMode = InputMode.PinchAndRotation;

    #endregion

    #region Setup

   

    #endregion

    #region Events registeration

    void OnEnable()
    {
        FingerGestures.OnRotationBegin += FingerGestures_OnRotationBegin;
        FingerGestures.OnRotationMove += FingerGestures_OnRotationMove;
        FingerGestures.OnRotationEnd += FingerGestures_OnRotationEnd;

        FingerGestures.OnPinchBegin += FingerGestures_OnPinchBegin;
        FingerGestures.OnPinchMove += FingerGestures_OnPinchMove;
        FingerGestures.OnPinchEnd += FingerGestures_OnPinchEnd;
        
    }

    void OnDisable()
    {
        FingerGestures.OnRotationBegin -= FingerGestures_OnRotationBegin;
        FingerGestures.OnRotationMove -= FingerGestures_OnRotationMove;
        FingerGestures.OnRotationEnd -= FingerGestures_OnRotationEnd;

        FingerGestures.OnPinchBegin -= FingerGestures_OnPinchBegin;
        FingerGestures.OnPinchMove -= FingerGestures_OnPinchMove;
        FingerGestures.OnPinchEnd -= FingerGestures_OnPinchEnd;
		
    }

    #endregion

    #region Rotation gesture

    bool rotating = false;
    bool Rotating
    {
        get { return rotating; }
        set
        {
            if( rotating != value )
            {
                rotating = value;
                UpdateTargetMaterial();
            }
        }
    }

    public bool RotationAllowed
    {
        get { return inputMode == InputMode.RotationOnly || inputMode == InputMode.PinchAndRotation; }
    }

    void FingerGestures_OnRotationBegin( Vector2 fingerPos1, Vector2 fingerPos2 )
    {
        if( RotationAllowed )
        {
            //UI.StatusText = "Rotation gesture started.";

            Rotating = true;
        }
    }

    void FingerGestures_OnRotationMove( Vector2 fingerPos1, Vector2 fingerPos2, float rotationAngleDelta )
    {
        if( Rotating )
        {
            //UI.StatusText = "Rotation updated by " + rotationAngleDelta + " degrees";

            // apply a rotation around the Z axis by rotationAngleDelta degrees on our target object
            target.Rotate( 0, 0, rotationAngleDelta );
			
			Debug.Log("ROTATION: " + rotationAngleDelta);
        }
    }

    void FingerGestures_OnRotationEnd( Vector2 fingerPos1, Vector2 fingerPos2, float totalRotationAngle )
    {
        if( Rotating )
        {
            //UI.StatusText = "Rotation gesture ended. Total rotation: " + totalRotationAngle;

            Rotating = false;
        }
    }

    #endregion

    #region Pinch Gesture

    bool pinching = false;
    bool Pinching
    {
        get { return pinching; }
        set
        {
            if( pinching != value )
            {
                pinching = value;
                UpdateTargetMaterial();
            }
        }
    }

    public bool PinchAllowed
    {
        get { return inputMode == InputMode.PinchOnly || inputMode == InputMode.PinchAndRotation; }
    }

    void FingerGestures_OnPinchBegin( Vector2 fingerPos1, Vector2 fingerPos2 )
    {
        if( !PinchAllowed )
            return;

        Pinching = true;
    }

    void FingerGestures_OnPinchMove( Vector2 fingerPos1, Vector2 fingerPos2, float delta )
    {
        if( Pinching )
        {
			
			Vector3 currentScale = target.transform.localScale;
			Vector3 newScale = delta * pinchScaleFactor * Vector3.one;
			
			currentScale += newScale;
			
			if(currentScale.x > 0.8f && currentScale.x < 4.3f){
            // change the scale of the target based on the pinch delta value
           		target.transform.localScale += newScale;
			}
			
			Debug.Log ("SCALE: " + target.transform.localScale.x );
        }
    }

    void FingerGestures_OnPinchEnd( Vector2 fingerPos1, Vector2 fingerPos2 )
    {
        if( Pinching )
        {
            Pinching = false;
        }
    }


    #endregion

    #region Misc 

    void UpdateTargetMaterial()
    {
        /*Material m;

        if( pinching && rotating )
            m = pinchAndRotationMaterial;
        else if( pinching )
            m = pinchMaterial;
        else if( rotating )
            m = rotationMaterial;
        else
            m = originalMaterial;

        target.renderer.sharedMaterial = m;*/
    }

    #endregion

    #region GUI

    public Rect inputModeButtonRect;

    void OnGUI()
    {
        //SampleUI.ApplyVirtualScreen();

        string buttonText;
        InputMode nextInputMode;
        
        switch( inputMode )
        {
            case InputMode.PinchOnly:
                buttonText = "Pinch Only";
                nextInputMode = InputMode.RotationOnly;
                break;

            case InputMode.RotationOnly:
                buttonText = "Rotation Only";
                nextInputMode = InputMode.PinchAndRotation;
                break;

            default:
                buttonText = "Pinch + Rotation";
                nextInputMode = InputMode.PinchOnly;
                break;
        }

        if( GUI.Button( inputModeButtonRect, buttonText ) )
        {
            inputMode = nextInputMode;
        }
    }

    #endregion
}
