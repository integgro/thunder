﻿using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Thunder.Web.Mvc.Html.Cnpj
{
    public class CnpjBuilder<TModel>
    {
        private readonly HtmlHelper<TModel> _helper;

        public CnpjBuilder(HtmlHelper<TModel> helper)
        {
            _helper = helper;
        }

        public MvcHtmlString Builder<TProperty>(Expression<Func<TModel, TProperty>> expression, object htmlAttributes)
        {
            var attributes = HtmlAttributesUtility.ObjectToHtmlAttributesDictionary(htmlAttributes);

            attributes.AddMaxLengthAttribute(expression, 18);
            attributes.AddCssClass("cnpj");

            return _helper.TextBoxFor(expression, attributes);
        }
    }
}
