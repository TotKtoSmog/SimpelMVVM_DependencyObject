using SimpelMVVM_DependencyObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace SimpelMVVM_DependencyObject.ViewModels
{
    internal class PersonsViewModel : DependencyObject
    {


        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilteerText", typeof(string), typeof(PersonsViewModel), new PropertyMetadata("", FilterText_Changed));

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as PersonsViewModel;
            if (current != null)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterPerson;
            }
        }

        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(PersonsViewModel), new PropertyMetadata(null));

        public PersonsViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(Person.GetPerrsons());
            Items.Filter = FilterPerson;
        }

        private bool FilterPerson(object obj)
        {
            bool result = true;
            string _FilterText = FilterText.ToLower();
            Person current = obj as Person;
            if (!string.IsNullOrWhiteSpace(_FilterText) && current != null 
                && !current.FirstName.ToLower().Contains(_FilterText)
                && !current.LastName.ToLower().Contains(_FilterText))
                result = false;
            return result;
        }
    }
}
