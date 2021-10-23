using Caliburn.Micro;
using DynamicInteraction.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DynamicInteraction.ViewModels
{
    public class ShellViewModel : Conductor<object>.Collection.AllActive
    {
        
        private const int NUM_CHECK_BOX = 3;
        private BindableCollection<CheckBoxModel> _checkBoxModel;
        private GraphViewModel _cartesianGraph;
        public ShellViewModel()
        {
            
            
            CheckBoxModel = new BindableCollection<CheckBoxModel>();
            
            List<CheckBoxModel> checkbox = new List<CheckBoxModel>();
            var check_1 = true;
            var name_1 = "Box 1";
            var box1 = new CheckBoxModel{ IsChecked = check_1, Name = name_1 };
            CheckBoxModel.Add(box1);
            var check_2 = true;
            var name_2 = "Box 2";
            var box2 = new CheckBoxModel { IsChecked = check_2, Name = name_2 };
            CheckBoxModel.Add(box2);
            var check_3 = true;
            var name_3 = "Box 3";
            var box3 = new CheckBoxModel { IsChecked = check_3, Name = name_3 };
            CheckBoxModel.Add(box3);
            CartesianGraph = new GraphViewModel(CheckBoxModel.Count);
        }
        
        public BindableCollection<CheckBoxModel> CheckBoxModel
        {
            get 
            { 
                return _checkBoxModel; 
            }
            set
            {
                _checkBoxModel = value;
                NotifyOfPropertyChange(() => CheckBoxModel);
            }
        }

        public GraphViewModel CartesianGraph
        {
            get
            { 
                return _cartesianGraph; 
            }
            set
            {
                _cartesianGraph = value;
                NotifyOfPropertyChange(() => CartesianGraph);
            }
        }

        public void Click()
        {
            int index = 0;
            foreach (var item in CheckBoxModel)
            {
                if (CheckBoxModel[index].IsChecked)
                {
                    CartesianGraph.VisibilityList[index] = Visibility.Visible;
                }
                else
                {
                    CartesianGraph.VisibilityList[index] = Visibility.Hidden;
                }
                index++;
            }
        }
        
    }
}
