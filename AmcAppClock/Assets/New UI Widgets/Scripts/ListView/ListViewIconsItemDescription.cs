﻿namespace UIWidgets
{
	using System;
	using System.ComponentModel;
	using UnityEngine;
	using UnityEngine.Serialization;

	/// <summary>
	/// ListViewIcons item description.
	/// </summary>
	[Serializable]
	public class ListViewIconsItemDescription : INotifyPropertyChanged
	{
		[SerializeField]
		[FormerlySerializedAs("Icon")]
		Sprite icon;

		/// <summary>
		/// The icon.
		/// </summary>
		public Sprite Icon
		{
			get
			{
				return icon;
			}

			set
			{
				if (icon != value)
				{
					icon = value;
					Changed("Icon");
				}
			}
		}

        //blantt ui
        [SerializeField]
        [FormerlySerializedAs("Name2")]
        string name2;
        public string Name2
        {
            get
            {
                return name2;
            }

            set
            {
                if (name2 != value)
                {
                    name2 = value;
                    Changed("Name2");
                }
            }
        }

        [SerializeField]
		[FormerlySerializedAs("Name")]
		string name;

		/// <summary>
		/// The name.
		/// </summary>
		public string Name
		{
			get
			{
				return name;
			}

			set
			{
				if (name != value)
				{
					name = value;
					Changed("Name");
				}
			}
		}

		[NonSerialized]
		string localizedName;

		/// <summary>
		/// The localized name.
		/// </summary>
		public string LocalizedName
		{
			get
			{
				return localizedName;
			}

			set
			{
				if (localizedName != value)
				{
					localizedName = value;
					Changed("LocalizedName");
				}
			}
		}

		[SerializeField]
		[FormerlySerializedAs("Value")]
		int val;

		/// <summary>
		/// The value.
		/// </summary>
		public int Value
		{
			get
			{
				return val;
			}

			set
			{
				if (val != value)
				{
					val = value;
					Changed("Value");
				}
			}
		}

		/// <summary>
		/// Occurs when a property value changes.
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged = Utilities.DefaultPropertyHandler;

		/// <summary>
		/// Raise PropertyChanged event.
		/// </summary>
		/// <param name="propertyName">Property name.</param>
		protected void Changed(string propertyName)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}