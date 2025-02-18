﻿namespace UIWidgets
{
	using UnityEngine;
	using UnityEngine.UI;

	/// <summary>
	/// Text proxy interface.
	/// </summary>
	public interface ITextProxy
	{
		/// <summary>
		/// Gameobject.
		/// </summary>
		GameObject GameObject
		{
			get;
		}

		/// <summary>
		/// Graphic component.
		/// </summary>
		Graphic Graphic
		{
			get;
		}

		/// <summary>
		/// Text.
		/// </summary>
		string text
		{
			get;
			set;
		}

		/// <summary>
		/// Color.
		/// </summary>
		Color color
		{
			get;
			set;
		}

		/// <summary>
		/// Font size.
		/// </summary>
		float fontSize
		{
			get;
			set;
		}
	}
}