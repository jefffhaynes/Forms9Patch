﻿using Xamarin.Forms;

namespace Forms9Patch
{
	/// <summary>
	/// Null cell view: DO NOT USE.  Used internally by Forms9Patch.ListView to display null items in a ListView
	/// </summary>
	class NullCellView : BaseCellView
	{

		readonly ColorGradientBox _upperEdge = new ColorGradientBox {
			StartColor = Color.FromRgba(0,0,0,0.24),
			EndColor = Color.FromRgba(0,0,0,0),
			VerticalOptions = LayoutOptions.Start,
			HeightRequest = 6
		};

		readonly ColorGradientBox _lowerEdge = new ColorGradientBox {
			StartColor = Color.FromRgba(0,0,0,0),
			EndColor = Color.FromRgba(0,0,0,0.12),
			VerticalOptions = LayoutOptions.EndAndExpand,
			HeightRequest = 2
		};

		readonly Xamarin.Forms.StackLayout _layout = new Xamarin.Forms.StackLayout {
			HeightRequest = 10,
			Spacing = 0,
			Orientation = StackOrientation.Vertical,
			BackgroundColor = Color.Transparent
		};

		/// <summary>
		/// DO NOT USE: Initializes a new instance of the <see cref="T:Forms9Patch.NullCellView"/> class.
		/// </summary>
		public NullCellView () {
			//var filler = new BoxView ();
			//filler.BindingContext = this;
			//filler.SetBinding (VisualElement.HeightRequestProperty,"HeightRequest",BindingMode.OneWay,new RequestedHeightConverter());
			//System.Diagnostics.Debug.WriteLine ("\t\t\t\tcreating NullCellView");
			_layout.SetBinding (HeightRequestProperty, "RequestedHeight");
			_layout.Children.Add(_upperEdge);
			_layout.Children.Add (_lowerEdge);
			SeparatorHeight = 0;
			Content = _layout;
		}

		/// <summary>
		/// Triggered by a BindingContextChange
		/// </summary>
		protected override void OnBindingContextChanged ()
		{
			_layout.BindingContext = BindingContext;
			base.OnBindingContextChanged ();
		}

	}

	/*
	public class RequestedHeightConverter : IValueConverter {
		#region IValueConverter implementation
		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return (double)value - 7;
		}
		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return (double)value + 7;
		}
		#endregion
		
	}
	*/
}
