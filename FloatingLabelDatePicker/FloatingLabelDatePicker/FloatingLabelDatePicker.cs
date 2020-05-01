
using Xamarin.Forms;

namespace FloatingLabelDatePicker
{
	public class FloatingLabelDatePicker : DatePicker
	{
		public static readonly BindableProperty TitleProperty = BindableProperty.Create(propertyName: nameof(Title), returnType: typeof(string), declaringType: typeof(FloatingLabelDatePicker), defaultValue: default(string), defaultBindingMode: BindingMode.TwoWay);

		public string Title
		{
			get => (string)GetValue(TitleProperty);
			set => SetValue(TitleProperty, value);
		}

	}
}
