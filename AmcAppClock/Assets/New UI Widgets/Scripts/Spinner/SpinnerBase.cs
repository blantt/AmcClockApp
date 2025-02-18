﻿// <auto-generated/>
// Auto-generated added to suppress names errors.

namespace UIWidgets
{
	using System;
	using System.Collections;
	using UIWidgets.Attributes;
	using UIWidgets.Styles;
	using UnityEngine;
	using UnityEngine.Events;
	using UnityEngine.EventSystems;
	using UnityEngine.Serialization;
	using UnityEngine.UI;

	/// <summary>
	/// Spinner validation.
	/// </summary>
	public enum SpinnerValidation
	{
		/// <summary>
		/// On key down.
		/// </summary>
		OnKeyDown = 0,

		/// <summary>
		/// On end input.
		/// </summary>
		OnEndInput = 1,
	}

	/// <summary>
	/// Spinner base class.
	/// </summary>
	/// <typeparam name="T">Type of spinner value.</typeparam>
	[DataBindSupport]
	public abstract class SpinnerBase<T> : UIWidgetsMonoBehaviour, IStylable, IUpgradeable, IValidateable
		where T : struct
	{
#pragma warning disable 0649
		[SerializeField]
		[HideInInspector]
		[Obsolete("Replaced with InputField.")]
		Text m_TextComponent;

		[SerializeField]
		[HideInInspector]
		[Obsolete("Replaced with InputField.")]
		Graphic m_Placeholder;

		[SerializeField]
		[HideInInspector]
		[Obsolete("Replaced with InputField.")]
		Graphic m_TargetGraphic;
#pragma warning restore 0649

		[FormerlySerializedAs("onSubmit")]
		[FormerlySerializedAs("m_OnSubmit")]
		[FormerlySerializedAs("m_EndEdit")]
		[SerializeField]
		[HideInInspector]
#if UNITY_2021_1_OR_NEWER
		InputField.EndEditEvent m_OnEndEdit = new InputField.EndEditEvent();
#else
		InputField.SubmitEvent m_OnEndEdit = new InputField.SubmitEvent();
#endif

		[FormerlySerializedAs("onValueChange")]
		[FormerlySerializedAs("m_OnValueChange")]
		[SerializeField]
		[HideInInspector]
		private InputField.OnChangeEvent m_OnValueChanged = new InputField.OnChangeEvent();

		/// <summary>
		/// InputField proxy.
		/// </summary>
		[Obsolete("Replaced with InputFieldAdapter.")]
		protected IInputFieldExtended InputField
		{
			get
			{
				return InputFieldAdapter;
			}
		}

		[SerializeField]
		InputFieldExtendedAdapter inputFieldAdapter;

		/// <summary>
		/// InputFieldAdapter.
		/// </summary>
		public InputFieldExtendedAdapter InputFieldAdapter
		{
			get
			{
				if (inputFieldAdapter == null)
				{
					InitInputField();
				}

				return inputFieldAdapter;
			}
		}

		/// <summary>
		/// The min.
		/// </summary>
		[SerializeField]
		[FormerlySerializedAs("_min")]
		protected T ValueMin;

		/// <summary>
		/// The max.
		/// </summary>
		[SerializeField]
		[FormerlySerializedAs("_max")]
		protected T ValueMax;

		/// <summary>
		/// The step.
		/// </summary>
		[SerializeField]
		[FormerlySerializedAs("_step")]
		protected T ValueStep;

		/// <summary>
		/// The value.
		/// </summary>
		[SerializeField]
		[FormerlySerializedAs("_value")]
		protected T SpinnerValue;

		/// <summary>
		/// The validation type.
		/// </summary>
		[SerializeField]
		public SpinnerValidation Validation = SpinnerValidation.OnKeyDown;

		/// <summary>
		/// Allow changing value during hold.
		/// </summary>
		[SerializeField]
		public bool AllowHold = true;

		/// <summary>
		/// Delay of hold in seconds for permanent increase/decrease value.
		/// </summary>
		[SerializeField]
		public float HoldStartDelay = 0.5f;

		/// <summary>
		/// Delay of hold in seconds between increase/decrease value.
		/// </summary>
		[SerializeField]
		public float HoldChangeDelay = 0.1f;

		/// <summary>
		/// Gets or sets the minimum.
		/// </summary>
		/// <value>The minimum.</value>
		[DataBindField]
		public T Min
		{
			get
			{
				return ValueMin;
			}

			set
			{
				ValueMin = value;
			}
		}

		/// <summary>
		/// Gets or sets the maximum.
		/// </summary>
		/// <value>The maximum.</value>
		[DataBindField]
		public T Max
		{
			get
			{
				return ValueMax;
			}

			set
			{
				ValueMax = value;
			}
		}

		/// <summary>
		/// Gets or sets the step.
		/// </summary>
		/// <value>The step.</value>
		[DataBindField]
		public T Step
		{
			get
			{
				return ValueStep;
			}

			set
			{
				ValueStep = value;
			}
		}

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
		[DataBindField]
		public T Value
		{
			get
			{
				return SpinnerValue;
			}

			set
			{
				SetValue(value);
			}
		}

		/// <summary>
		/// The plus button.
		/// </summary>
		[SerializeField]
		[FormerlySerializedAs("_plusButton")]
		protected ButtonAdvanced plusButton;

		/// <summary>
		/// The minus button.
		/// </summary>
		[SerializeField]
		[FormerlySerializedAs("_minusButton")]
		protected ButtonAdvanced minusButton;

		/// <summary>
		/// Use unscaled time.
		/// </summary>
		[SerializeField]
		public bool UnscaledTime;

		/// <summary>
		/// Gets or sets the plus button.
		/// </summary>
		/// <value>The plus button.</value>
		public ButtonAdvanced PlusButton
		{
			get
			{
				return plusButton;
			}

			set
			{
				if (plusButton != null)
				{
					plusButton.onClick.RemoveListener(OnPlusClick);
					plusButton.onPointerDown.RemoveListener(OnPlusButtonDown);
					plusButton.onPointerUp.RemoveListener(OnPlusButtonUp);
				}

				plusButton = value;

				if (plusButton != null)
				{
					plusButton.onClick.AddListener(OnPlusClick);
					plusButton.onPointerDown.AddListener(OnPlusButtonDown);
					plusButton.onPointerUp.AddListener(OnPlusButtonUp);
				}
			}
		}

		/// <summary>
		/// Gets or sets the minus button.
		/// </summary>
		/// <value>The minus button.</value>
		public ButtonAdvanced MinusButton
		{
			get
			{
				return minusButton;
			}

			set
			{
				if (minusButton != null)
				{
					minusButton.onClick.RemoveListener(OnMinusClick);
					minusButton.onPointerDown.RemoveListener(OnMinusButtonDown);
					minusButton.onPointerUp.RemoveListener(OnMinusButtonUp);
				}

				minusButton = value;

				if (minusButton != null)
				{
					minusButton.onClick.AddListener(OnMinusClick);
					minusButton.onPointerDown.AddListener(OnMinusButtonDown);
					minusButton.onPointerUp.AddListener(OnMinusButtonUp);
				}
			}
		}

		/// <summary>
		/// onPlusClick event.
		/// </summary>
		public UnityEvent onPlusClick = new UnityEvent();

		/// <summary>
		/// onMinusClick event.
		/// </summary>
		public UnityEvent onMinusClick = new UnityEvent();

		/// <summary>
		/// Increase value on step.
		/// </summary>
		public abstract void Plus();

		/// <summary>
		/// Decrease value on step.
		/// </summary>
		public abstract void Minus();

		/// <summary>
		/// Sets the value.
		/// </summary>
		/// <param name="newValue">New value.</param>
		protected abstract void SetValue(T newValue);

		/// <summary>
		/// Start this instance.
		/// </summary>
		protected virtual void Start()
		{
			Init();
		}

		bool isInited;

		/// <summary>
		/// Init InputField.
		/// </summary>
		protected void InitInputField()
		{
			Upgrade();
		}

		/// <summary>
		/// Check if target has any InputFieldExtended component.
		/// </summary>
		/// <returns>true if target has any InputFieldExtended component; otherwise false.</returns>
		protected virtual bool HasInputField(GameObject target)
		{
			var input = target.GetComponent<InputFieldExtended>();
			if (input != null)
			{
				return true;
			}

#if UIWIDGETS_TMPRO_SUPPORT && (UNITY_5_2 || UNITY_5_3 || UNITY_5_3_OR_NEWER)
			var tmpro = target.GetComponent<InputFieldTMProExtended>();
			if (tmpro != null)
			{
				return true;
			}
#endif

			return false;
		}

		/// <summary>
		/// Init.
		/// </summary>
		public void Init()
		{
			if (isInited)
			{
				return;
			}

			isInited = true;

			InitInputField();

			InputFieldAdapter.Validation = SpinnerValidate;
			InputFieldAdapter.ValueChanged = ValueChange;
			InputFieldAdapter.ValueEndEdit = ValueEndEdit;

			PlusButton = plusButton;
			MinusButton = minusButton;
			Value = SpinnerValue;

			SetTextValue();
		}

		/// <summary>
		/// Set text value.
		/// </summary>
		protected virtual void SetTextValue()
		{
			InputFieldAdapter.Value = SpinnerValue.ToString();
		}

		/// <summary>
		/// Hold Plus coroutine.
		/// </summary>
		/// <returns>IEnumerator.</returns>
		protected virtual IEnumerator HoldPlus()
		{
			if (AllowHold)
			{
				yield return UtilitiesTime.Wait(HoldStartDelay, UnscaledTime);
				while (AllowHold)
				{
					Plus();
					yield return UtilitiesTime.Wait(HoldChangeDelay, UnscaledTime);
				}
			}
		}

		/// <summary>
		/// Hold Minus coroutine.
		/// </summary>
		/// <returns>IEnumerator.</returns>
		protected virtual IEnumerator HoldMinus()
		{
			if (AllowHold)
			{
				yield return UtilitiesTime.Wait(HoldStartDelay, UnscaledTime);
				while (AllowHold)
				{
					Minus();
					yield return UtilitiesTime.Wait(HoldChangeDelay, UnscaledTime);
				}
			}
		}

		/// <summary>
		/// Process the minus click event.
		/// </summary>
		public void OnMinusClick()
		{
			Minus();
			onMinusClick.Invoke();
		}

		/// <summary>
		/// Process the plus click event.
		/// </summary>
		public void OnPlusClick()
		{
			Plus();
			onPlusClick.Invoke();
		}

		IEnumerator coroutine;

		/// <summary>
		/// Process the plus button down event.
		/// </summary>
		/// <param name="eventData">Current event data.</param>
		public void OnPlusButtonDown(PointerEventData eventData)
		{
			if (coroutine != null)
			{
				StopCoroutine(coroutine);
			}

			coroutine = HoldPlus();
			StartCoroutine(coroutine);
		}

		/// <summary>
		/// Process the plus button up event.
		/// </summary>
		/// <param name="eventData">Current event data.</param>
		public void OnPlusButtonUp(PointerEventData eventData)
		{
			StopCoroutine(coroutine);
			coroutine = null;
		}

		/// <summary>
		/// Process the minus button down event.
		/// </summary>
		/// <param name="eventData">Current event data.</param>
		public void OnMinusButtonDown(PointerEventData eventData)
		{
			if (coroutine != null)
			{
				StopCoroutine(coroutine);
			}

			coroutine = HoldMinus();
			StartCoroutine(coroutine);
		}

		/// <summary>
		/// Process the minus button up event.
		/// </summary>
		/// <param name="eventData">Current event data.</param>
		public void OnMinusButtonUp(PointerEventData eventData)
		{
			StopCoroutine(coroutine);
			coroutine = null;
		}

		/// <summary>
		/// Process the destroy event.
		/// </summary>
		protected virtual void onDestroy()
		{
			PlusButton = null;
			MinusButton = null;
		}

		/// <summary>
		/// Called when value changed.
		/// </summary>
		/// <param name="value">Value.</param>
		protected abstract void ValueChange(string value);

		/// <summary>
		/// Called when end edit.
		/// </summary>
		/// <param name="value">Value.</param>
		protected abstract void ValueEndEdit(string value);

		char SpinnerValidate(string validateText, int charIndex, char addedChar)
		{
			if (Validation == SpinnerValidation.OnEndInput)
			{
				return ValidateShort(validateText, charIndex, addedChar);
			}
			else
			{
				return ValidateFull(validateText, charIndex, addedChar);
			}
		}

		/// <summary>
		/// Validate when key down for Validation=OnEndInput.
		/// </summary>
		/// <returns>The char.</returns>
		/// <param name="validateText">Validate text.</param>
		/// <param name="charIndex">Char index.</param>
		/// <param name="addedChar">Added char.</param>
		protected abstract char ValidateShort(string validateText, int charIndex, char addedChar);

		/// <summary>
		/// Validates when key down for Validation=OnKeyDown.
		/// </summary>
		/// <returns>The char.</returns>
		/// <param name="validateText">Validate text.</param>
		/// <param name="charIndex">Char index.</param>
		/// <param name="addedChar">Added char.</param>
		protected abstract char ValidateFull(string validateText, int charIndex, char addedChar);

		/// <summary>
		/// Clamps a value between a minimum and maximum value.
		/// </summary>
		/// <returns>The bounds.</returns>
		/// <param name="value">Value.</param>
		protected abstract T InBounds(T value);

		#region IStylable implementation

		/// <inheritdoc/>
		public virtual bool SetStyle(Style style)
		{
			SetStyle(style.Spinner, style);

			return true;
		}

		/// <summary>
		/// Set the specified style for specified spinner.
		/// </summary>
		/// <param name="styleSpinner">Spinner style data.</param>
		/// <param name="style">Style data.</param>
		public virtual void SetStyle(StyleSpinner styleSpinner, Style style)
		{
			InputFieldAdapter.SetStyle(styleSpinner, style);

			styleSpinner.Background.ApplyTo(transform.parent);
			styleSpinner.InputBackground.ApplyTo(GetComponent<Image>());

			if (minusButton != null)
			{
				styleSpinner.ButtonMinus.ApplyTo(minusButton.gameObject);
			}

			if (plusButton != null)
			{
				styleSpinner.ButtonPlus.ApplyTo(plusButton.gameObject);
			}
		}

		/// <inheritdoc/>
		public virtual bool GetStyle(Style style)
		{
			GetStyle(style.Spinner, style);

			return true;
		}

		/// <summary>
		/// Set style options from widget properties.
		/// </summary>
		/// <param name="styleSpinner">Spinner style data.</param>
		/// <param name="style">Style data.</param>
		public virtual void GetStyle(StyleSpinner styleSpinner, Style style)
		{
			InputFieldAdapter.GetStyle(styleSpinner, style);

			styleSpinner.Background.GetFrom(transform.parent);
			styleSpinner.InputBackground.GetFrom(GetComponent<Image>());

			if (minusButton != null)
			{
				styleSpinner.ButtonMinus.GetFrom(minusButton.gameObject);
			}

			if (plusButton != null)
			{
				styleSpinner.ButtonPlus.GetFrom(plusButton.gameObject);
			}
		}

		#endregion

		/// <summary>
		/// Upgrade this instance.
		/// </summary>
		public virtual void Upgrade()
		{
#pragma warning disable 0612, 0618
			var target = (inputFieldAdapter != null) ? inputFieldAdapter.gameObject : gameObject;
			if (!HasInputField(target) && (m_TextComponent != null))
			{
				var input = target.AddComponent<InputFieldExtended>();
				input.textComponent = m_TextComponent;
				input.placeholder = m_Placeholder;
				input.targetGraphic = m_TargetGraphic;

				input.onEndEdit = m_OnEndEdit;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
				input.onValueChanged = m_OnValueChanged;
#else
				input.onValueChange = m_OnValueChanged;
#endif
			}

			m_TextComponent = null;
			m_Placeholder = null;
			m_TargetGraphic = null;
#pragma warning restore 0612, 0618

			Utilities.GetOrAddComponent(this, ref inputFieldAdapter);
		}

#if UNITY_EDITOR
		/// <summary>
		/// Validate instance.
		/// </summary>
		public virtual void Validate()
		{
			Compatibility.Upgrade(this);
		}
#endif
	}
}