//@graysuit
//https://discord.com/invite/Hu5XPGMTuk
//https://github.com/Back-X/Universal-VM-Detector
using System;
using System.Windows.Forms;

public class Universal_VM_Detector
{
	static void Main()
	{
		bool IsVM = (new System.Management.ManagementObjectSearcher("SELECT * FROM Win32_PortConnector")).Get().Count < 0;
		MessageBox.Show
		(
		    "You are using " + (IsVM ? "Virtual" : "Real") + " Environment", 
			"Universal VM Detector", 
			MessageBoxButtons.OK, 
			(IsVM ? MessageBoxIcon.Warning : MessageBoxIcon.Information)
	    );
    }
}