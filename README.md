# Unity Scriptable Object with GUID

_This repository contains a simple way that exposes the globally unique identifier (GUID) of a Scriptable Object retrieved from the Unity asset database._

Basically, is a simple wrapper over the System.GUID:

- It relies over the System.GUID.
- It exposes the GUID in the inspector.
- It offers a custom way to collect all the Scriptable Objects with the GUID.

## Why

In some cases, it can be very useful to have scriptable objects tied to a unique UID rather than the entire object itself. This allows for decoupling of dependencies between systems, and simply requires these systems to possess a string instead of the entire scriptable object.

By using a unique identifier, we can easily reference and manipulate specific instances of scriptable objects without the need to pass around the entire object. This can help streamline code and improve performance, especially when dealing with large amounts of data.

Additionally, using UIDs can make it easier to implement version control and data management systems, as the unique identifier can be used to track changes and updates to specific instances of scriptable objects.

## Installation

Prerequisite: this repository use the Unity Package Manager (UPM), you need to use Unity Version >= 2018.3

Simply add the link of this repository to the Unity Package Manager.

## Documentation

Just make your scriptable object inherit from `SerializableScriptableObject` class

```c#
using UnityEngine;
using UnityExtendedScriptable;

public class Gun : SerializableScriptableObject
{
    [SerializeField]
    private string m_gunName;
    [SerializeField]
    private float m_gunDamage;
    [SerializeField]
    private float m_gunHealth;

    /// . . .
}
```

And access via

```C#
    //  . . .

    private Gun myGun;

    // ...

    var gunGUID = myGun.Guid;
    Debug.Log(gunGUID);
```

More info here
