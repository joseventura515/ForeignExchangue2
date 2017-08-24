

namespace ForeignExchangue2.ViewModels
{
    using Models;
    using GalaSoft.MvvmLight.Command;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using System;

    public class MainViewModel
    {
        #region Properties
        public string Amount
        {
            get;
            set;
        }

        private ObservableCollection<Rate> Rates
        {
            get;set;
        }

        private Rate SourceRate
        {
            get;set;
        }
        private Rate TargetRate
        {
            get;set;
        }
        public bool IsRunning
        {
            get;set;
        } 
        public bool IsEnable
        {
            get;set;
        }
        public string Result
        {
            get;set;
        }
        #endregion
        public MainViewModel()
        {

        }
        #region Command
        public ICommand ConvertCommand
        {
            get
            {
                return new RelayCommand(Convert);
            }
        }

        private void Convert()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
