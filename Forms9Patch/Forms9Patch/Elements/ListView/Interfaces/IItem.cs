﻿using System;
using Xamarin.Forms;

namespace Forms9Patch
{
	/// <summary>
	/// Interface used to queary current state of Forms9Patch.ListView cells and the ItemSource object bound to the cells view.
	/// </summary>
	public interface IItem
	{
		/// <summary>
		/// Gets a value indicating whether this cell's separator is visible.
		/// </summary>
		/// <value><c>true</c> if separator is visible; otherwise, <c>false</c>.</value>
		bool SeparatorIsVisible { get; }

		/// <summary>
		/// Gets the color of this cell's separator.
		/// </summary>
		/// <value>The color of the separator.</value>
		Color SeparatorColor { get; }

		/// <summary>
		/// Gets the height of this cell's separator.
		/// </summary>
		/// <value>The height of the separator.</value>
		double SeparatorHeight { get; }

		/// <summary>
		/// Gets the separator left indent for this cell.
		/// </summary>
		/// <value>The separator left indent.</value>
		double SeparatorLeftIndent { get; }

		/// <summary>
		/// Gets the separator right indent for this cell.
		/// </summary>
		/// <value>The separator right indent.</value>
		double SeparatorRightIndent { get; }

		/// <summary>
		/// Gets the unselected background color for this cell.
		/// </summary>
		/// <value>The color of the cell background.</value>
		Color CellBackgroundColor { get; }

		/// <summary>
		/// Gets the selected background color for this cell.
		/// </summary>
		/// <value>The color of the selected cell background.</value>
		Color SelectedCellBackgroundColor { get; }

		/// <summary>
		/// Gets the accessory position for this cell (very likely to be obsoleted!
		/// </summary>
		/// <value>The accessory position.</value>
		AccessoryPosition AccessoryPosition { get; }

		/// <summary>
		/// Gets the function that generates the accessory text for this cell.  Very likely to be obsoleted
		/// </summary>
		/// <value>The accessory text.</value>
		Func<IItem, string> AccessoryText { get; }

		/// <summary>
		/// Gets a value indicating whether this cell is selected.
		/// </summary>
		/// <value><c>true</c> if is selected; otherwise, <c>false</c>.</value>
		bool IsSelected { get; }

		/// <summary>
		/// Gets the ListView's ItemsSource object that is bound to this cell's View
		/// </summary>
		/// <value>The source.</value>
		object Source { get; }

		/// <summary>
		/// Gets the index (within the current group, if any) of this cell.
		/// </summary>
		/// <value>The index.</value>
		int Index { get; }
	}
}

