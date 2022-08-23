![](https://img.shields.io/badge/Builder-Design-informational?style=flat&logo=design&color=61DAFB)

<p>
<ul>
  <li> <b>Builder Design Pattern</b> is used when we want to make complex objects, so that we can differentiate the class and it's implementation.Later we can use the same class to make different objects.
  </li>
  <li> Let's suppose we want to build Phone product which have specifications like , RAM,ROM,Display,Camera,Microphone  which is common in all phones but specifications may vary on the basis of operating system or other factors eg, 
   for android and iphone.In this case builder pattern is the most suitable one to build the generic class for the different objects.</li>
  <li>
    Steps to follow: 
    <ul>
      <li> 
        Firstly create the <b>Product class</b> which will conatin all the common properties
      </li>
      <li>
        Then make the <b>Builder interface</b> which will contain all the apis or methods which will be using in making the product and then implement 
        those methods inside the <b>Concrete Builder class</b>.
      </li>
      <li>Now we will be using a <b>Director class</b> which will implement the builder interface and will generate a sequence to build the product. </li>
      <li>Last step to use the <b>Director class</b> inside Client Code ( main program ) </li>
      </ul>
    
  </li>
  </ul>
</p>
<hr>

Reference : <a href="https://dotnettutorials.net/lesson/builder-design-pattern/">Builder Design pattern</a>

