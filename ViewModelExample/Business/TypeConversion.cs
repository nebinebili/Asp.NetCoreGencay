﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ViewModelExample.Business
{
    public static class TypeConversion
    {
        public static TResult Conversion<T, TResult>(T model)where TResult:class,new()
        {
            TResult result = new TResult();
            typeof(T).GetProperties().ToList().ForEach(p =>
            {
                PropertyInfo property = typeof(TResult).GetProperty(p.Name);
                property.SetValue(result, p.GetValue(model));
            });

            return result;
        }
    }
}
