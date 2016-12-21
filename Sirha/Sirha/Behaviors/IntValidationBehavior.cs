using Xamarin.Forms;

namespace Sirha.Behaviors
{
    class IntValidationBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            if (entry == null) return;
            entry.TextChanged += entryTextChanged;
            base.OnAttachedTo(entry);
        }

        private void entryTextChanged(object sender, TextChangedEventArgs e)
        {
            int result;
            var isValid = int.TryParse(e.NewTextValue, out result);
            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            if (entry == null) return;
            entry.TextChanged -= entryTextChanged;
            base.OnDetachingFrom(entry);
        }
    }
}
