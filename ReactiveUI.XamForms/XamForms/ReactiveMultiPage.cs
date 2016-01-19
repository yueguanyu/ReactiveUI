﻿using System;
using ReactiveUI;
using Xamarin.Forms;

namespace ReactiveUI.XamForms
{
    public abstract class ReactiveMultiPage<TPage, TViewModel> : MultiPage<TPage>, IViewFor<TViewModel>
        where TPage : Page
        where TViewModel : class
    {
        /// <summary>
        /// The ViewModel to display
        /// </summary>
        public TViewModel ViewModel {
            get { return (TViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }
        public static readonly BindableProperty ViewModelProperty = 
            BindableProperty.Create<ReactiveContentPage<TViewModel>, TViewModel>(x => x.ViewModel, default(TViewModel), BindingMode.OneWay);

        object IViewFor.ViewModel {
            get { return ViewModel; }
            set { ViewModel = (TViewModel)value; }
        }
    }
}