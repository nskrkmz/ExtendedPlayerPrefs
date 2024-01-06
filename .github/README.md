# Nesco - ExtendedPlayerPrefs

This package introduces additional functionalities for handling various data types conveniently in UnityEngine.PlayerPrefs

### Install via package manager

Please follow the instrustions:
* open **Edit/Project Settings/Package Manager**
* add a new Scoped Registry (or edit the existing OpenUPM entry)
```
NAME => package.openupm.com
URL => https://package.openupm.com
SCOPE(S) => com.nesco.extendedplayerprefs
```
* click **Save** or **Apply**
* open **Window/Package Manager**
* select Add package by name... or Add package from git URL...
* paste **com.nesco.extendedplayerprefs** into name or __https://github.com/nskrkmz/ExtendedPlayerPrefs.git__ into git URL
* paste **1.0.0** into version
* click **Add**
  
#### Alternatively, merge the snippet to Packages/manifest.json
```json
{
    "scopedRegistries": [
        {
            "name": "package.openupm.com",
            "url": "https://package.openupm.com",
            "scopes": [
                "com.nesco.extendedplayerprefs"
            ]
        }
    ],
    "dependencies": {
        "com.nesco.crashreporter": "1.0.0"
    }
}

```
#### Install via command-line interface
```shell
$ openupm add com.nesco.extendedplayerprefs
```

### Usage

add it to your script file before using

```csharp
    using Nesco.EPP;
```

#### Usage examples for Quaternion
<details open>
<summary>Usage examples for Quaternion</summary>

```csharp
    ExtendedPlayerPrefs.SetQuaternion(YOUR_KEY, VALUE);
```

```csharp
    ExtendedPlayerPrefs.GetQuaternion(YOUR_KEY);
```

```csharp
    ExtendedPlayerPrefs.GetQuaternion(YOUR_KEY, DEFAULT_VALUE);
```
</details>

<details open>
<summary>Usage examples for Color</summary>

```csharp
    ExtendedPlayerPrefs.SetColor(YOUR_KEY, VALUE);
```

```csharp
    ExtendedPlayerPrefs.GetColor(YOUR_KEY);
```

```csharp
    ExtendedPlayerPrefs.GetColor(YOUR_KEY, DEFAULT_VALUE);
```
</details>

<details open>
<summary>Usage examples for Vector3 and Vector3Int</summary>

* Vector3
```csharp
    ExtendedPlayerPrefs.SetVector3(YOUR_KEY, VALUE);
```

```csharp
    ExtendedPlayerPrefs.GetVector3(YOUR_KEY);
```

```csharp
    ExtendedPlayerPrefs.GetVector3(YOUR_KEY, DEFAULT_VALUE);
```

* Vector3Int
```csharp
    ExtendedPlayerPrefs.SetVector3Int(YOUR_KEY, VALUE);
```

```csharp
    ExtendedPlayerPrefs.GetVector3Int(YOUR_KEY);
```

```csharp
    ExtendedPlayerPrefs.GetVector3Int(YOUR_KEY, DEFAULT_VALUE);
```
</details>

<details open>
<summary>Usage examples for Vector2 and Vector2Int</summary>

* Vector2
```csharp
    ExtendedPlayerPrefs.SetVector2(YOUR_KEY, VALUE);
```

```csharp
    ExtendedPlayerPrefs.GetVector2(YOUR_KEY);
```

```csharp
    ExtendedPlayerPrefs.GetVector2(YOUR_KEY, DEFAULT_VALUE);
```

* Vector2Int
```csharp
    ExtendedPlayerPrefs.SetVector2Int(YOUR_KEY, VALUE);
```

```csharp
    ExtendedPlayerPrefs.GetVector2Int(YOUR_KEY);
```

```csharp
    ExtendedPlayerPrefs.GetVector2Int(YOUR_KEY, DEFAULT_VALUE);
```
</details>

<details open>
<summary>Usage examples for Vector4</summary>

```csharp
    ExtendedPlayerPrefs.SetVector4(YOUR_KEY, VALUE);
```

```csharp
    ExtendedPlayerPrefs.GetVector4(YOUR_KEY);
```

```csharp
    ExtendedPlayerPrefs.GetVector4(YOUR_KEY, DEFAULT_VALUE);
```
</details>

<details open>
<summary>Usage examples for Boolean</summary>

```csharp
    ExtendedPlayerPrefs.SetBool(YOUR_KEY, VALUE);
```

```csharp
    ExtendedPlayerPrefs.GetBool(YOUR_KEY);
```

```csharp
    ExtendedPlayerPrefs.GetBool(YOUR_KEY, DEFAULT_VALUE);
```
</details>

<details open>
<summary>Usage examples for Character</summary>

```csharp
    ExtendedPlayerPrefs.SetChar(YOUR_KEY, VALUE);
```

```csharp
    ExtendedPlayerPrefs.GetChar(YOUR_KEY);
```

```csharp
    ExtendedPlayerPrefs.GetChar(YOUR_KEY, DEFAULT_VALUE);
```
</details>

<details open>
<summary>Usage examples for Double</summary>

```csharp
    ExtendedPlayerPrefs.SetDouble(YOUR_KEY, VALUE);
```

```csharp
    ExtendedPlayerPrefs.GetDouble(YOUR_KEY);
```

```csharp
    ExtendedPlayerPrefs.GetDouble(YOUR_KEY, DEFAULT_VALUE);
```
</details>

<details open>
<summary>Usage examples for Generic</summary>

> [!IMPORTANT]  
> To use these methods, you need to add the [Newtonsoft.Json](https://docs.unity3d.com/Packages/com.unity.nuget.newtonsoft-json@3.2/manual/index.html) package to your project.

```csharp
    ExtendedPlayerPrefs.SetGeneric<typof(YOUR_OBJ)>(YOUR_KEY, YOUR_OBJ);
```

```csharp
    ExtendedPlayerPrefs.GetGeneric<typof(YOUR_OBJ)>(YOUR_KEY);
```

```csharp
    ExtendedPlayerPrefs.GetGeneric<typof(YOUR_OBJ)>(YOUR_KEY, DEFAULT_VALUE);
```
</details>