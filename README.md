# Unity-android
University Project - Roll-a-ball Unity

# Getting Started
Alustasin sellega, et tegin uue projekti: https://docs.unity3d.com/Manual/GettingStarted.html

# Roll-A-Ball
Leidsin ametlik Unity tutoorial: https://unity3d.com/ru/learn/tutorials/s/roll-ball-tutorial

Antud tutoorial on hästi struktureeritud ning lihtsalt arusaadav.

# Added functionality
Et oleks võimalik androidis mängida, tuleb teha vajalik muudatus ```PlayerController.cs``` failis

Enne:
```
float moveHorizontal= Input.GetAxis("Horizontal");
float moveVertical= Input.GetAxis("Vertical");
```
Nüüd:
```
float moveHorizontal = Input.acceleration.x;
float moveVertical = Input.acceleration.y; 
```

# Project Screenshot
![github-small](https://i.imgur.com/6ieWJSb.png)
