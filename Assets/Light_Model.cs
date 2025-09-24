using UnityEngine;

public class Light_Model : MonoBehaviour, IUsable
{
	public Light light;
	
    public void Use()
    {
	    // Turn on light
	    light.enabled = !light.enabled;
    }
}
