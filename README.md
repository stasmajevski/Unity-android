# Unity-android
University Project


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


![github-small](https://i.imgur.com/6ieWJSb.png)
