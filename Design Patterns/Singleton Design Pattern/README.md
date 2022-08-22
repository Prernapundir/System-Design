![](https://img.shields.io/badge/Singleton-Design-informational?style=flat&logo=design&color=61DAFB)

<p>
1. In Singleton Design Patten the instance of the class is created only once and all other threads or process should refer this single instance.<br>
2. Using singleton design pattern we can save lot of memory , as we are only creating the single instance of the class and using it throughout.<br><br>
<b>3.Steps to implement Singleton Design Pattern</b><br>
<ul>
<li>Make Private constructor, so that no other class can create the object directly</li>
<li> Make the Singleton class sealed , so that we can restrict our class to be inherited by nested or non-non-nested classes</li>
<li>By two ways we can create the instance of the Singleton class either by using <b>Lazy Initialization implementation</b> or by <b>Eager Initialization implementation</b>.</li>
<li> <b>Lazy Initialization</b> is performance effective, as here we are creating instance on-demand wherease in<b> Eager Initialization</b> instance will be created at the time of class-loading irrespective of the future use.
<li><i><b>Double Checked Locking</b></i> is also required if we are implementing Lazy Initialization without using Lazy Keyword for the thread-safety</li>
<li> <b>Lazy Keyword</b> do the check for thread-safety behind the scenes
</ul>
</p>
<hr>

Reference : <a href="https://www.c-sharpcorner.com/article/singleton-design-pattern-in-c-sharp-part-two/#:~:text=It%20helps%20application%20load%20faster,can%20say%20non%2Dlazy%20initialization.">Singelton Design pattern</a>

