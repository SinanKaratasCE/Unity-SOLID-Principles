using UnityEngine;

namespace SOLID.InterfaceSegregation
{

public interface IRestorable
{
	public float Health { get; set; }
	
	public void RestoreHealth();
}

}