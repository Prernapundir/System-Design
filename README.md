
#### Scalability

How to design systems that can handle millions of people hitting it all at once ?

<b> - Single Server Design( Database resides on server itself) </b>
   
   
![image](https://user-images.githubusercontent.com/33116849/233579091-3fbc60de-5229-45f5-9346-3dedb1dbee47.png)

Good for personal use (small scale) systems or when we don't receive much traffic on the server and we can handle the downtime of the server. The drawback of this system is that it has a single point of failure, so it's not a good choice for large-scale systems.

<b> - Separating out the Database </b>

![image](https://user-images.githubusercontent.com/33116849/233582162-ae410c01-4b87-4308-8ec8-c63a8c7b4c5c.png)

Here we have separated out our database and server, so it's a little better as we can scale out the server and database independently. But still, if anyone goes down, your website will go down too. So from a resiliency standpoint, this is not a good choice at all.


<b>How to scale the system ?</b>

![image](https://user-images.githubusercontent.com/33116849/233584941-82a056f0-03dd-44bb-bb67-9785d64fd097.png)


- <b>Vertical Scaling </b> 

    With vertical scaling, we can increase the size of the server. But it has limitations in size, as we can increase the size of the server up to a certain limit. And it also has a single point of failure.

- <b>Horizontal Scaling</b>

    This is the safest option for most of the system designs today. In horizontal scaling, we can add more and more servers, and with the help of load balancers, we can distribute the load. If any server goes down, load balancers will automatically reroute the traffic to other servers. So we solved the problem of a single point of failure. And it will be good if servers are stateless here.

