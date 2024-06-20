## OpsCommandType.Discount



### Guide

| Property | Requirement | Note                                                         |
| -------- | ----------- | ------------------------------------------------------------ |
| Number   | Yes         | EMC Discount #Number                                         |
| Text     | No          | This depends on your discount configuration, if your discount is a fixed amount, it will be a fixed amount. If your discount is a percentage discount, it will be a percentage. |
|          |             | *More.....*                                                  |



### Code

```c#
this.OpsContext.ProcessCommand(new OpsCommand(OpsCommandType.Discount)
{
    Number = 901,
    Text = "15.5"
});
```

