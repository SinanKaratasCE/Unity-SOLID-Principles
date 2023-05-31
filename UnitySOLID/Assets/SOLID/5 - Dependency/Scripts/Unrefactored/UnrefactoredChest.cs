using UnityEngine;

namespace SOLID.Dependency
{

public class UnrefactoredChest : MonoBehaviour
{
	public void Open()
	{
	    Debug.Log("The chest is open.");
	}

	public void Close()
	{
	    Debug.Log("The chest is closed.");
	}
}

}