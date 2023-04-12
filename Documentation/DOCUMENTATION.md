# DOC

Table of Content

- [Installation](https://github.com/saffiriogiorgio/unity-scriptable-object-guid/edit/main/Documentation/DOCUMENTATION.md#Installation)
- [Usage](https://github.com/saffiriogiorgio/unity-scriptable-object-guid/edit/main/Documentation/DOCUMENTATION.md#Usage)
- [How it works](https://github.com/saffiriogiorgio/unity-scriptable-object-guid/edit/main/Documentation/DOCUMENTATION.md#How-it-works)

# Installation

Prerequisite: this repository use the Unity Package Manager (UPM), you need to use Unity Version >= 2018.3

Simply add the link of this repository to the Unity Package Manager.

```
https://github.com/saffiriogiorgio/unity-scriptable-object-guid.git
```

# Usage

If you want your scriptable object expose its GUID, just make it inherit from the `SerializableScriptableObject` class.

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

    // . . .

    var gunGUID = myGun.Guid;
    Debug.Log(gunGUID);
```

# How it works

The struct `Guid.cs` is a very simple wrapper of the System.GUID struct. As the `System.GUID` is not serializable, the wrapper is necessary to have a custom inspector for the `Guid` type and have the Scriptable Object's Guid visibile in the inspector.

Some operators are already define: no need to convert the `Guid` struct into a `System.Guid` or into a string if you need to print it.

```C#

    // . . .
    // this is correct
    System.Guid gunGUID = myGun.Guid.GetGUID;

    // this is also correct
    System.Guid gunGUID = myGun.Guid;

    // ToString already implemented
    Debug.Log(myGun.Guid);
```

You can explicit how to format the Guid by following these rules: [Microsoft Documentation Guid Formatting](https://learn.microsoft.com/it-it/dotnet/api/system.guid.tostring?view=net-8.0)

```C#
    // N
    myGun.Guid.ToString("N"); // 00000000000000000000000000000000

    // D
    myGun.Guid.ToString("D"); // 00000000-0000-0000-0000-000000000000

    // B
    myGun.Guid.ToString("B"); // {00000000-0000-0000-0000-000000000000}

    // P
    myGun.Guid.ToString("P"); // (00000000-0000-0000-0000-000000000000)

    // X
    myGun.Guid.ToString("X"); // {0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}}
```

default one is `D`.
