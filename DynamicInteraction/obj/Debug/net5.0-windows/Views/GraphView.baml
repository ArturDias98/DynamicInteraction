   M S B A M L   `   `   `  ����M  IDynamicInteraction, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:DynamicInteraction.ViewsDynamicInteraction.Views  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      M+clr-namespace:DynamicInteraction.ViewModelsDynamicInteraction.ViewModels  6O   (    "DynamicInteraction.Views.GraphView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:DynamicInteraction.Views     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      B
viewmodels+clr-namespace:DynamicInteraction.ViewModels     6O   .��5
      � .+�5   
   �   � 	Resources  5         CleanSeparator �� 
TargetType  LiveCharts.Wpf.Separator �� Property �� Value��%Z   &	        �� 5      "  6/   .�5      ��  � {�$ False��62   6B   5      5       � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $��* �6    6-   .+�5      �� $��0��6   $
��Wrap=�6%   5      #  LiveCharts.Wpf.CartesianChart  5      $��2��6!   &   LiveCharts.Wpf.Charts.Base.Chart   	Hoverable$ False��6E      DisableAnimations$
 True��6W      DataTooltip 6.   Z�    AxisY 5        LiveCharts.Wpf.Axis  	   
Foreground
	 ����6     5      
	 �\\��
   Position$
 RightTop=�66      	Separator 5        5      #��[  6,   6V   5        5       
	 �/kU�$
 RightTop=�6;    5!        5"      #��[  6,   6V   5$         Series 5'        LiveCharts.Wpf.LineSeries    LiveCharts.Wpf.Series   Values;  5LiveCharts.Wpf.Converters.NumericChartValuesConverter$ 	1,5,3,5,3 6%      	ScalesYAt$ 0��68      Fill
 ����    PointGeometry 6Y   Z� y�6s   �� *VisibilityList[0]+ �� Mode$ OneWay=�  5)      $ 	1,4,2,4,2 6%   $ 1��69   
 ����  6Z   Z� y�6s   �� *VisibilityList[1]+  5+      $ 	1,7,4,7,4 6%   $ 2��69   
 ����  6Z   Z� y�6s   �� *VisibilityList[2]+5.      5/      50      51      