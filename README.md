# ShareOnLan

ShareOnLan is a Windows Desktop Application which allows to send files or folders between two or more computers exploiting the LAN network as means of transmission.

# Specifications of the implemented system

- The sharing service, running in background, allows to notify to the other hosts present in the local network the availability of the own host. In order to discover the presence of such hosts, it is used a discovery machanism based on the use of the UDP multicast packets.
- The host can be setted up in private mode: in this case it will not reveals its presence to the other hosts on the network and it will not be able to receive any file, but to send instead. The host setted in public mode, instead, notifies its presence, in order to accept files comining from other network hosts, behaving as server. If the user of a host selects the context menu (right click) on a file or folder, an option will be showed which allows to share the file or the folder toward all hosts that revealed theirself or a subgroup of them. In this case, the host works as client. 
- The connection among the hosts involved in the file/folder transfer, will be based on TCP protocol.
- In the case of files with the same name on the same path, an incremental index will be assigned as suffix to the file name in order to handle duplicates.
- The host that is sending a file, will shows a progress bar, a real-time time estimation to completion and will provides to the user the chance to delete the operation.

### Used Technologies and language

* .NET Framework version 4.7.2
* C#
* Windows Form
* [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin) - Theming .NET WinFormsto Google's Material Design Principles.

### Implementation

To resume, the protocols, libraries and tools used are:

* UDP Multicast - to announce the online hosts
* TCP  - to send file and folders among hostst
* Multithreading (BackgroundWorkers, Threads)
* Windows Form - to make the UI. The MaterialSkin Nuget packet has been installed to use the Material Design library

## Author

* **Simone Riggi** - simone.riggi92@gmail.com
