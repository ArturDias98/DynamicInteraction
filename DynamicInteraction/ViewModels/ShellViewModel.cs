using Caliburn.Micro;
using DynamicInteraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicInteraction.ViewModels
{
    public class ShellViewModel : Conductor<object>.Collection.AllActive
    {
        private BindableCollection<CheckBoxModel> _checkBoxModel;
        private GraphViewModel _cartesianGraph;
        public ShellViewModel()
        {
            CartesianGraph = new GraphViewModel();
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

    }
}
