using System;
using CollectionViewDemo.MVVM.Models;
namespace CollectionViewDemo.Selectors
{
	public class ProductDataTemplateSelector : DataTemplateSelector
	{
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var product = item as Product;
            if (!product.HasOffer)
            {
                Application.Current.Resources.TryGetValue("ProductStyle", out var productStyle);
                return productStyle as DataTemplate;
            }
            return new DataTemplate();
        }
    }
}

