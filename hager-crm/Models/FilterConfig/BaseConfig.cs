﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Primitives;

namespace hager_crm.Models.FilterConfig
{
    /*
     * Using configs to determine how to filter model.
     * Grid Filter Accepts implementation of ModelConfig 
     * interface that allows to work with different models.
     * Pros: Simple, Quick
     * Cons: For more complex filtering rules this approach will take lots of code duplication
     * SumUp: Perfect for small simple databases.
     */
    public interface IModelConfig<TSource>
    {
        public List<BaseFilterRule> GetFilteringRules();
        
        public Dictionary<string, ConfigAction<TSource>> GetActions();
    }

    public class ConfigAction<TSource>
    {
        public Func<object, IQueryable<TSource>, IQueryable<TSource>> OnFilter;
        public Func<object, IQueryable<TSource>, IQueryable<TSource>> OnSort;
    }
    
    public abstract class BaseFilterRule
    {
        private string displayName;
        public string DisplayName
        {
            get => displayName ?? FieldName;
            set => displayName = value;
        }
        public string FieldName;
        public string FieldType;

        public abstract string GetHtml(ViewContext context);
    }

    public class InputFilterRule : BaseFilterRule
    {
        public override string GetHtml(ViewContext context)
        {
            var inputValue = "";
            if (context.HttpContext.Request.Query.TryGetValue(FieldName, out var values))
                inputValue = values.FirstOrDefault() ?? "";
            return $@"
            <input id=""{FieldName + "FilterRule"}"" class=""form-control data-filterable"" 
                   data-name=""{FieldName}"" type=""{FieldType}"" value=""{inputValue}""/>";
        } 
    }
    
    public class CheckboxFilterRule : BaseFilterRule
    {
        public override string GetHtml(ViewContext context)
        { 
            var inputValue = "";
            if (context.HttpContext.Request.Query.TryGetValue(FieldName, out var values))
                inputValue = values.FirstOrDefault() ?? "";
            return $@"
            <input id=""{FieldName + "FilterRule"}"" class=""data-filterable"" 
                   data-name=""{FieldName}"" type=""checkbox"" value=""on"" {(inputValue == "on" ? "checked" : "")}/>";
        }
    }
    
    public class DropdownFilterRule : BaseFilterRule
    {
        public override string GetHtml(ViewContext context)
        {
            if (!(context.ViewData[FieldName] is SelectList options))
                throw new ArgumentException($"There is no select list found for field name: {FieldName}");

            var inputValue = "";
            if (context.HttpContext.Request.Query.TryGetValue(FieldName, out var values))
                inputValue = values.FirstOrDefault() ?? "";
            
            var result = $@"
            <select id=""{FieldName + "FilterRule"}"" class=""form-control data-filterable"" data-name=""{FieldName}"">
                <option value="""">--Select {DisplayName}--</option>
                {string.Join('\n', 
                options.Select(i => 
                    $@"<option value=""{i.Value}"" {(i.Value == inputValue ? "selected" : "")}>{i.Text}</option>"))}
            </select>";
            return result;
        }
    }
    
    
}
