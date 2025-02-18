﻿namespace UIWidgets
{
	using UnityEngine;
	using UnityEngine.UI;

	/// <summary>
	/// Text null.
	/// Used when not found any text component.
	/// </summary>
	public class TextNull : ITextProxy
	{
		/// <summary>
		/// GameObject.
		/// </summary>
		public GameObject GameObject
		{
			get
			{
				return null;
			}
		}

		/// <summary>
		/// Graphic.
		/// </summary>
		public Graphic Graphic
		{
			get
			{
				return null;
			}
		}

		/// <summary>
		/// Color.
		/// </summary>
		public Color color
		{
			get
			{
				return Color.clear;
			}

			set
			{
			}
		}

		/// <summary>
		/// Text.
		/// </summary>
		public string text
		{
			get
			{
				return null;
			}

			set
			{
			}
		}

		/// <summary>
		/// Font size.
		/// </summary>
		public float fontSize
		{
			get
			{
				return 0;
			}

			set
			{
			}
		}
	}
}