## DataStore.ReadExtensionDataValue

Firstly, Data needs to be added to EMC.

**Enterprise**->**Data Extensions**

![image-20231011211056669](./images/image20231011211056669.png)

field value.

![image-20231011211522023](./images/image20231011211522023.png)



read the dataExtension.

```c#
       [ExtensibilityMethod]
        public void Part9Test1()
        {
            Logger.LogAlways("Part9Test1");


            var test1 = this.DataStore.ReadExtensionDataValue("Property", "Test1", this.OpsContext.PropertyID);
            var test2 = this.DataStore.ReadExtensionDataValue("Property", "Test2", this.OpsContext.PropertyID);

            this.OpsContext.ShowMessage($"{test1} and {test2}");

        }
```



run method.

![image-20231011212059071](./images/image20231011212059071.png)

