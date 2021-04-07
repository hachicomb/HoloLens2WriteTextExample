# Overview

- Write the text file in HoloLens 2.
- Download text file from Device Portal (HoloLens 2).

![image](https://raw.githubusercontent.com/hachicomb/HoloLens2WriteTextExample/master/images/ss01.png)
![image](https://raw.githubusercontent.com/hachicomb/HoloLens2WriteTextExample/master/images/ss02.png)

# Enviroment
- Unity 2019.4.22f1
- MixedRealityFeatureTool-1.0.2103.2-Beta
- MRTK 2.6.0

# To save text file into AppData folder

## CSharp code
```
var path = Application.persistentDataPath + "\\my_file.txt";
using (StreamWriter sw = File.AppendText(path))
{
    string s = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    sw.WriteLine(s);
}
```

# The persistent data path to save text file

```
C:\Data\Users\{USER_NAME}\AppData\Local\Packages\{APP_NAME}_{ID}\LocalState
```

# Purpose

- Application log (Debug build is very slow. So we try write application log in Release build.)
- config.json
- We can read the text file that upload in Device Portal (HoloLens 2).
