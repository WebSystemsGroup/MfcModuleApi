using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using FluentValidation.Results;

namespace SalaryCore.Extensions
{
    public static class FluentValidationExtensions
    {
        public static IEnumerable ErrorMessage(this IEnumerable<ValidationFailure> errors) => errors.Select(s=>new {s.PropertyName, s.ErrorMessage}).ToList();

        public static IRuleBuilderOptions<T, string> ValidateName<T>(this IRuleBuilder<T, string> ruleBuilder, string message) => ruleBuilder.NotEmpty().WithMessage(message);

        public static IRuleBuilderOptions<T, string> MaxLength<T>(this IRuleBuilder<T, string> ruleBuilder, string name,int max) => ruleBuilder.MaximumLength(max).WithMessage($"{name} содержит более {max} символов");

        public static IRuleBuilderOptions<T, string> CheckComment<T>(this IRuleBuilder<T, string> ruleBuilder) => ruleBuilder.MaximumLength(255).WithMessage("Комментарий содержит более 255 символов");
        
        public static IRuleBuilderOptions<T, DateTime> CheckDate<T>(this IRuleBuilder<T, DateTime> ruleBuilder)=> ruleBuilder.NotEqual(DateTime.MinValue).WithMessage("Дата имеет не корректное значание").NotEqual(DateTime.MaxValue).WithMessage("Дата имеет не корректное значание");
        
        public static IRuleBuilderOptions<T, DateTime?> CheckDate<T>(this IRuleBuilder<T, DateTime?> ruleBuilder) => ruleBuilder.NotEqual(DateTime.MinValue).WithMessage("Дата имеет не корректное значание").NotEqual(DateTime.MaxValue).WithMessage("Дата имеет не корректное значание");
        
    }
}