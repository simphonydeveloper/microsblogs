## CustomDialog  from WPF——Build a complete dialog box

In Part3, a simple dialog was implemented, as simple as only displaying a paragraph of text. This will make the dialog more complete, with an input box, cancel, and OK buttons.

### UserControl

Firstly, I need to implement the desired effects in the custom WPF UserControl.

```xaml
<UserControl x:Class="WPFExample.Controls.MyCustomDialogControl"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:local="clr-namespace:WPFExample.Controls"
             mc:Ignorable="d" 
             d:DesignHeight="450" d:DesignWidth="800">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition/>
            <RowDefinition/>
        </Grid.RowDefinitions>

        <TextBox Grid.Row="0" Width="200" Height="50" Text="{Binding Data.UserName}" x:Name="userName"></TextBox>

        <StackPanel Grid.Row="1" Orientation="Horizontal" HorizontalAlignment="Center">
            <Button Width="100" Height="50" x:Name="btn_cancel">Cancel</Button>
            <Button Width="100" Height="50" x:Name="btn_ok" Margin="20,0,0,0">OK</Button>
        </StackPanel>
    </Grid>
</UserControl>
 
 
```



![image20230920204809425](./images/image20230920204809425.png)

### Extensibility

[OpsContext.RequestCustomDialog Method (oracle.com)](https://docs.oracle.com/cd/E91245_01/api/html/6a3b7593-183d-b660-25f9-abab63f37314.htm)

Now I will use a model as the data to accept user input.

```c#
    public class Part4Model
    {
        public string UserName { get; set; }
    }
```

ExtensibilityMethod

```c#
        [ExtensibilityMethod]
        public void Part4Test1()
        {
            Logger.LogAlways("Part4Test1");

            string contentName = "MyCustomDialogControl";

            Part4Model part4Model = new Part4Model();
            var dialogResult = this.OpsContext.RequestCustomDialog("test message", "test title", contentName, part4Model);

            //the dialogResult data type is Part4Model

            if (dialogResult == null)
                return;
            else
            {
                var result = dialogResult as Part4Model;
                this.OpsContext.ShowMessage(result.UserName);
            }
        }
```



### EMC Content

The buttons in EMC are different from those in UserControl.

UserControl: **Button**

ECM: **mcontrol:Button** OpsCommand="**DialogCancel**"/OpsCommand="**DialogOk**" ,This is the key code.

```xaml
<UserControl xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
        xmlns:system="clr-namespace:System;assembly=mscorlib"
        xmlns:mconverters="clr-namespace:Micros.OpsUI.Converters;assembly=OpsUI"
        xmlns:mcontrol="clr-namespace:Micros.OpsUI.Controls;assembly=OpsUI"
        xmlns:mcfg="clr-namespace:Micros.OpsUI.Controls.Configuration;assembly=OpsUI"
        xmlns:mdesign="clr-namespace:Micros.OpsUI.Controls.Design;assembly=OpsUI"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             mc:Ignorable="d" 
             d:DesignHeight="450" d:DesignWidth="800">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition/>
            <RowDefinition/>
        </Grid.RowDefinitions>

        <TextBox Grid.Row="0" Width="200" Height="50" Text="{Binding Data.UserName}" x:Name="userName"></TextBox>

        <StackPanel Grid.Row="1" Orientation="Horizontal" HorizontalAlignment="Center">
             <mcontrol:Button OpsCommand="DialogCancel" OpsCommandText="1"    Width="100" Height="50" x:Name="btn_cancel">Cancel</mcontrol:Button>
             <mcontrol:Button OpsCommand="DialogOk" OpsCommandText="1"    Width="100" Height="50" x:Name="btn_ok" Margin="20,0,0,0">OK</mcontrol:Button>
        </StackPanel>
    </Grid>
</UserControl>
 
```



Test in POS

![GIF 2023-9-20 21-03-34](./images\GIF2023920210334.gif)