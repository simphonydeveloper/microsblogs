using Micros.PosCore.Extensibility;
using Micros.PosCore.GuestProfile.MvvmTools;
using SimphonyExample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimphonyExample
{
    /// <summary>
    /// part5
    /// </summary>
    public partial class SimphonyExampleApplication
    {
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
    }
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
}
