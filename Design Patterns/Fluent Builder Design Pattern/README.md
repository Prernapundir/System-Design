
![](https://img.shields.io/badge/FluentBuilder-Design-informational?style=flat&logo=design&color=61DAFB)

<p>
<ul>
  <li> <b>Fluent Builder Design Pattern</b> is the variation of <b>Builder Design Pattern</b> where we can apply the <b><i>method chaining </i></b> over the methods of our builder class.Method chaining we can implement by returning the "object" itself using this object.
    
      For Example :
        Student student = new();
        student.firstName("Joey").lastName("Tribbiani").age(25);
    
  <li>
    Steps to implement Fluet Builder Design Pattern :
    <ul>
      <li>In Builder Design pattern , builder interface contains all the methods of data type <b>void </b>, here we need to change it to <b>IBuilder</b> data type, becoz we are going to return the object by returning <b>this</b> pointer from all our methods so that we can do the chaining of methods .
      </li>
      <li>From the <b>Concrete Builder Classes</b> we have yo return <b>this</b> object</li>
      <li>Last step , in <b>Director class</b> lets do the chaining of methods .</li>
    </ul>
  </li>
  <li>Advantages :
    <ul>
      <li>Code will be more readable and usable.</li>
      <li>This pattern widely used in LINQ queries ,Fluent Validationand moq testing.</li>
        <li> That's how we create the Fluent Api's  .
    </ul>
  </li>
  </ul>
</p>
<hr>
  
Reference : <a href="https://code-maze.com/builder-design-pattern/">Fluent Builder Design pattern</a>

