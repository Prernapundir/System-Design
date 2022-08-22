
 # 1. Singleton Design Patten -> In Singletion Design Pattern , the instance of the class is created only once.
 # 2. We can save lot of memory , as we are only creating the instance once and using it at global level.
 # 3.Steps to implement Singleton Design Pattern
 ###   3.1 Make private constructor -> So that no other class can ct=reate the object directly
 ###   3.2 Make the Singleton class sealed -> So that non-derived or derived class can inherit singletion class
 ###   3.3 Use Lazy implementation /Eager implementation for creating the instances
 ###   3.4 Check for thread safety also , so use lock (one of the implementation)
