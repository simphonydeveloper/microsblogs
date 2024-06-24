## Remote Debugging

Usually, when debugging ExtensionApplication, we use an additional process to debug it. Of course, if Simphony is installed on your development computer, it's quite simple.

What should we do if our development computer needs to connect to Simphony debugging on other machines?



### Download

First, download the Remote Debugger tool for VS2022.According to your VS version, download the content.

https://learn.microsoft.com/en-us/visualstudio/debugger/remote-debugging?view=vs-2022

![image-20240624211154309](./images/image-20240624211154309.png)



### Install

After successful download, the Remote DebuggerTool needs to be installed on the Simphony machine that needs to be debugged.



### Use

Open the Remote Debugger.You can see the tool waiting for new connection.

![image-20240624211646084](./images/image-20240624211646084.png)

Return to the development computer.

Open the VS2022.

![image-20240624211945419](./images/image-20240624211945419.png)

Go to **Debug**-**Attach to Process**.Change **Connection type** to **Remote**



![image-20240624212100748](./images/image-20240624212100748.png)

Click **Find** Button.Wait for a while, and it will automatically discover the computer that the Remote Debugger is turned on.

![image-20240624212201013](./images/image-20240624212201013.png)

Click the Pc and Select.

![image-20240624212329616](./images/image-20240624212329616.png)

Now,you can see all remote pc process.And you can also see that the Remote Debugger is connected.

![image-20240624212410579](./images/image-20240624212410579.png)

![image-20240624212522663](./images/image-20240624212522663.png)

Select the process for **ServiceHost**->Click **Attach** button.Then start your debugging.