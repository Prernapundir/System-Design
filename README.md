
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
    
    
#### Where do servers come from ?

1. Provisioned within your own company's data centres
2. Cloud services (i.e, Amazpn EC2, Azure Vm's)
3. Fully managed serverless services (like Azure functions , Lambda functions )

#### Scaling the database
- <b>Failover servers : Cold Standby </b>

   <img src="https://user-images.githubusercontent.com/33116849/233587946-6c539066-fd93-42fd-bad5-d7462c6f9802.png" width="50%"/>

   In this approach, we have two databases: one is the primary database, and one is the backup database (called cold standby), which should be called upon in the event of the primary database's failure. Backup should be done here periodically.I have a few downsides too, like a decent amount of downtime and data loss.Upside is its cheap but still not a good choice for highly available systems.


-  <b>Warm Standby </b>

   Instead of a periodic database, we have constant replication of the data from the primary database to the warm standby database. So it's always ready to replace the primary database without much downtime. It can have little data loss as well, but still, it's a far superior approach.
   
- <b> Hot Standby</b>

   Instead of relying on the replication mechanism, here we will write it in all the instances of the database, so if the primary database goes down, we can instantly route the traffic to the standby database.




  
