using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System;
using learningMVVM.View;

namespace learningMVVM.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {


        //���ļ�ΪMainWindow.xaml��VM�㣬��ҳ����Ҫ�����ݺ�ҵ���߼���

        public MainViewModel()
        {
            Modules = new List<Module>
            {
                new Module() {Name = "module1" },
                new Module() {Name = "module2" },
                new Module() {Name = "module3" },
                new Module() {Name = "module4" },
                new Module() {Name = "module5" },
            };

            OpenCommand = new RelayCommand<string>(o => OpenPage(o));


        }

        private void OpenPage(string name)
        {
            Page = new Page(name);
        }

        public List<Module> Modules { get; private set; }


        //֪ͨ�����Ѿ����ģ�����ҳ�����
        private object _page;
        public object Page
        {
            get { return _page; }
            set { _page = value; RaisePropertyChanged(); }
        }

        public RelayCommand<string> OpenCommand { get; private set; }

    }
}