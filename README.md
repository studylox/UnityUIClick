# UnityUIClick
unity UI点击物品显示/关闭弹窗面板



1.UI->image/Canvas/Panel  
设置用户UI面板
面板上添加图片：先把图片转换形式才能放在image上。

2.AnimationCurve组件
在携程中使用，用于获取曲线数据。可以利用其特点设置弹窗的弹出和回去的渐变效果。
曲线的两点的坐标值可以控制UI面板的大小。

3.UI组件挂载脚本
脚本一般放在新建的EmptyGameObject上

4.Panel组件
Panel属于GameObject,不属于UI组件。
Panel可以控制背景色透明度
Panel自然挂载image组件，可以贴图，但图片必须先转换成Sprite(2D and UI)类型。

5.协程Coroutine
打破代码加载顺序只能从上到下，协程部分的代码可以和其它代码同时进行加载，从而减少加载数据的时间。
