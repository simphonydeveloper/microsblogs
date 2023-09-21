## CustomDialog  from WPF——MVVM

[MVVM]([Model-View-ViewModel - .NET | Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm))

### Preview

![GIF 2023-9-20 22-05-05](images\GIF-2023-9-20 22-05-05.gif)



### ViewModel

The BaseViewModel namespace **Micros.PosCore.GuestProfile.MvvmTools**

**RelayCommand** is used to implement commands

```c#
 public class Part5ViewModel : BaseViewModel
    {
        public RelayCommand Refresh { get; set; }

        private string _userName;
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                this.SetProperty(ref _userName, value);
            }
        }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                this.SetProperty(ref _age, value);
            }
        }
    }
```





### View

```xaml
<UserControl x:Class="WPFExample.Controls.MyCustomDialogControl_Part5"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:local="clr-namespace:WPFExample.Controls"
             mc:Ignorable="d" 
             d:DesignHeight="450" d:DesignWidth="800">
    <GroupBox>
        <GroupBox.Header>Part5</GroupBox.Header>
        <Grid>
            <Grid.RowDefinitions>
                <RowDefinition/>
                <RowDefinition/>
                <RowDefinition/>
            </Grid.RowDefinitions>

            <Grid Grid.Row="0">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition/>
                    <ColumnDefinition/>
                </Grid.ColumnDefinitions>
                <TextBlock Text="UserName:" HorizontalAlignment="Right" VerticalAlignment="Center"/>
                <TextBlock Grid.Column="1" Text="{Binding Data.UserName}" HorizontalAlignment="Left" VerticalAlignment="Center"/>
            </Grid>
            <Grid Grid.Row="1">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition/>
                    <ColumnDefinition/>
                </Grid.ColumnDefinitions>
                <TextBlock Text="Age:" HorizontalAlignment="Right" VerticalAlignment="Center"/>
                <TextBlock Grid.Column="1" Text="{Binding Data.Age}" HorizontalAlignment="Left" VerticalAlignment="Center"/>
            </Grid>
            <StackPanel Grid.Row="2" Orientation="Horizontal" HorizontalAlignment="Center">
                <Button Width="100" Height="50" x:Name="btn_cancel">Cancel</Button>
                <Button Width="100" Height="50" x:Name="btn_ok" Margin="20,0,0,0">OK</Button>
                <Button Width="100" Height="50" Command="{Binding Data.Refresh}" x:Name="btn_refresh" Margin="20,0,0,0">Refresh</Button>
            </StackPanel>
        </Grid>
    </GroupBox>
</UserControl>

```

### Model

```c#
        [ExtensibilityMethod]
        public void Part5Test1()
        {
            Logger.LogAlways("Part5Test1");

            string contentName = "MyCustomDialogControl";

            Part5ViewModel part5ViewModel = new Part5ViewModel();

            part5ViewModel.UserName = "simphony";
            part5ViewModel.Age = 10;
            part5ViewModel.Refresh = new RelayCommand(() =>
            {
                Random rd = new Random();
                int i = rd.Next(0, 99);
                part5ViewModel.Age = i;
            });

            var dialogResult = this.OpsContext.RequestCustomDialog("test message", "test title", contentName, part5ViewModel);

            if (dialogResult == null)
                return;
            else
            {
                var result = dialogResult as Part5ViewModel;
                this.OpsContext.ShowMessage(result.UserName + ":" + result.Age);
            }
        }
```



### EMC Content

```xaml
<UserControl
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
        xmlns:system="clr-namespace:System;assembly=mscorlib"
        xmlns:mconverters="clr-namespace:Micros.OpsUI.Converters;assembly=OpsUI"
        xmlns:mcontrol="clr-namespace:Micros.OpsUI.Controls;assembly=OpsUI"
        xmlns:mcfg="clr-namespace:Micros.OpsUI.Controls.Configuration;assembly=OpsUI"
        xmlns:mdesign="clr-namespace:Micros.OpsUI.Controls.Design;assembly=OpsUI"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
        mc:Ignorable="d"
        d:DesignHeight="200" d:DesignWidth="200">
        <GroupBox>
        <GroupBox.Header>Part5</GroupBox.Header>
        <Grid>
            <Grid.RowDefinitions>
                <RowDefinition/>
                <RowDefinition/>
                <RowDefinition/>
            </Grid.RowDefinitions>

            <Grid Grid.Row="0">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition/>
                    <ColumnDefinition/>
                </Grid.ColumnDefinitions>
                <TextBlock Text="UserName:" HorizontalAlignment="Right" VerticalAlignment="Center"/>
                <TextBlock Grid.Column="1" Text="{Binding Data.UserName}" HorizontalAlignment="Left" VerticalAlignment="Center"/>
            </Grid>
            <Grid Grid.Row="1">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition/>
                    <ColumnDefinition/>
                </Grid.ColumnDefinitions>
                <TextBlock Text="Age:" HorizontalAlignment="Right" VerticalAlignment="Center"/>
                <TextBlock Grid.Column="1" Text="{Binding Data.Age}" HorizontalAlignment="Left" VerticalAlignment="Center"/>
            </Grid>
            <StackPanel Grid.Row="2" Orientation="Horizontal" HorizontalAlignment="Center">
                 <mcontrol:Button OpsCommand="DialogCancel" OpsCommandText="1"    Width="100" Height="50" x:Name="btn_cancel">Cancel</mcontrol:Button>
                 <mcontrol:Button OpsCommand="DialogOk" OpsCommandText="1"    Width="100" Height="50" x:Name="btn_ok" Margin="20,0,0,0">OK</mcontrol:Button>
                 <Button Width="100" Height="50" Command="{Binding Data.Refresh}" x:Name="btn_refresh" Margin="20,0,0,0">Refresh</Button>
            </StackPanel>
        </Grid>
    </GroupBox>

</UserControl>
```

