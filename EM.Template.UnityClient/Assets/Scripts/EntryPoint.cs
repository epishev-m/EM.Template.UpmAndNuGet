using EM.Template.ModuleFirst;
using EM.Template.ModuleSecond;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
	private void Awake()
	{
		var moduleFirst = new ModuleFirst();
		var moduleSecond = new ModuleSecond();
	}
}
