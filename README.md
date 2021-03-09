Under construction...

# Universal VM Detector
Detect every windows virtual machine with just 1 line of code

## Why we need universal way ?
Malware are now more clever than before. Before running, they check whether environment is virtual or real. 
But big problem they face, how to get an uinversal way to detect every type of VM ?
Most common is to search and match values from win32. But this method is static and for a limited versions of VMs. What if there are 1000+ VM manufacturers ? then you would have to write a code to match 1000+ VM signatures. But its time waste. Even after sometime, there would be new other VMs launched and your script would be wasted.

## Background
I worked on it for many months. I done many tests upon which I observed that:
**win32_portconnector** always null and empty on VMs. Please see full report
```
//asked at: https://stackoverflow.com/q/64846900/14919621
what **win32_portconnector** is used for ? This question have 3 parts.
1) What is the use case of **[win32_portconnector][1]** ?                           [1]: https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-portconnector
2) **Can I get state of ports** using it like Mouse cable, charger, HDMI cables etc ?
3) Why **VM** have null results on this query :**Get-WmiObject Win32_PortConnector** ?
```
**On VM:**
```ps
PS C:\Users\Administrator> Get-WmiObject Win32_PortConnector
``` 
**On Real environment:**
```ps
PS C:\Users\Administrator> Get-WmiObject Win32_PortConnector
Tag                         : Port Connector 0
ConnectorType               : {23, 3}
SerialNumber                :
ExternalReferenceDesignator :
PortType                    : 2

Tag                         : Port Connector 1
ConnectorType               : {21, 2}
SerialNumber                :
ExternalReferenceDesignator :
PortType                    : 9

Tag                         : Port Connector 2
ConnectorType               : {64}
SerialNumber                :
ExternalReferenceDesignator :
PortType                    : 16

Tag                         : Port Connector 3
ConnectorType               : {22, 3}
SerialNumber                :
ExternalReferenceDesignator :
PortType                    : 28

Tag                         : Port Connector 4
ConnectorType               : {54}
SerialNumber                :
ExternalReferenceDesignator :
PortType                    : 17

Tag                         : Port Connector 5
ConnectorType               : {38}
SerialNumber                :
ExternalReferenceDesignator :
PortType                    : 30

Tag                         : Port Connector 6
ConnectorType               : {39}
SerialNumber                :
ExternalReferenceDesignator :
PortType                    : 31
``` 

## Codes
Based upon these tests, I have made an tiny program which can detect windows VMs.
You can [read code](Universal_VM_Detector.cs#L11) or get [compiled executable](actions).


