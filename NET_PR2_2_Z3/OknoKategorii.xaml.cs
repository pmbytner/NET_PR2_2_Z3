﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace NET_PR2_2_Z3;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class OknoKategorii : Window
{
	public OknoKategorii()
	{
		InitializeComponent();
	}

	private void Szczegóły(object sender, RoutedEventArgs e)
	{
		XmlElement wybranaKategoria = (XmlElement)ListaKategorii.SelectedItem;
		if(wybranaKategoria != null )
			new OknoSzczegółów(
				wybranaKategoria
				).Show();
	}
}
