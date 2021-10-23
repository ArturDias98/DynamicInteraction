using Caliburn.Micro;
using DynamicInteraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DynamicInteraction.ViewModels
{
    public class GraphViewModel : Screen
    {
        public GraphViewModel(int numLines)
        {
            Graph = new GraphModel();
            VisibilityList = new BindableCollection<Visibility>();
            
            for (int i = 0; i < numLines; i++)
            {
                VisibilityList.Add(Visibility.Visible);
            }
            
            
        }
        private GraphModel _graph;

        public GraphModel Graph
        {
            get { return _graph; }
            set { _graph = value; }
        }

        private BindableCollection<Visibility> _visibilityList;

        public BindableCollection<Visibility> VisibilityList
        {
            get
            { 
                return _visibilityList; 
            }
            set
            { 
                _visibilityList = value;
                NotifyOfPropertyChange(() => VisibilityList);
            }
        }

    }
    

}
