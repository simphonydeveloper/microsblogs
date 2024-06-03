## Page Design-Custom Content Loader

### Preview

![image-20240603171041224](./images/image-20240603171041224.png)

### How to achieve it?

Firstly, you need to create a record in the **Setup** -**Custom Content**- **Content**.

Content-Type：Loose Xaml

```xaml
<UserControl 
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
       >
    <Grid>
     <TextBlock Text="Simphony POS" Foreground="Green" FontSize="100" ></TextBlock>
    </Grid>
</UserControl>
```



Go to **Configuration**- **User Experience**-**Page Design**

This feature will currently cause my EMC to lag.

![image-20240603173156458](./images/image-20240603173156458.png)

Select your Content record.

![image-20240603173254007](./images/image-20240603173254007.png)



On the design page on the right, you can also drag to change the size.