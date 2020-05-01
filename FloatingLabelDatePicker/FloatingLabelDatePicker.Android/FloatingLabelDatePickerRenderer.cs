using Android.Content;
using Android.Widget;
using FloatingLabelDatePicker.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Material.Android;
using Xamarin.Forms.Platform.Android;
using AColor = Android.Graphics.Color;
using XDatePicker = Xamarin.Forms.DatePicker;

[assembly: ExportRenderer(typeof(FloatingLabelDatePicker.FloatingLabelDatePicker), typeof(FloatingLabelDatePickerRenderer), new[] { typeof(VisualMarker.MaterialVisual) })]
namespace FloatingLabelDatePicker.Droid
{
	public class FloatingLabelDatePickerRenderer : MaterialDatePickerRenderer
	{
		private MaterialPickerTextInputLayout _layout;

		public FloatingLabelDatePickerRenderer(Context context) : base(context)
		{
		}

		protected override MaterialPickerTextInputLayout CreateNativeControl()
		{
			_layout = base.CreateNativeControl();
			return _layout;
		}

		protected override void OnElementChanged(ElementChangedEventArgs<XDatePicker> e)
		{
			base.OnElementChanged(e);
			FloatingLabelDatePicker element = Element as FloatingLabelDatePicker;

			if (!string.IsNullOrWhiteSpace(element.Title))
			{
				UpdateTitle(element.Title);
			}
		}

		public void UpdateTitle(string hint)
		{
			SetHint(Element, hint);
		}

		private void SetHint(VisualElement element, string hint)
		{
			_layout.HintEnabled = !string.IsNullOrWhiteSpace(hint);
			if (_layout.HintEnabled)
			{
				element?.InvalidateMeasureNonVirtual(InvalidationTrigger.VerticalOptionsChanged);
				_layout.Hint = hint;
			}
		}
	}
}