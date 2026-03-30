using Academy_2.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class UniqueDirectionNameAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
        {
            return ValidationResult.Success;
        }

        string directionName = value.ToString();

        IDbContextFactory<Academy_2Context> dbContextFactory = validationContext.GetService<IDbContextFactory<Academy_2Context>>();
        if (dbContextFactory == null)
        {
            return new ValidationResult("Database context factory not available.");
        }

        using (var context = dbContextFactory.CreateDbContext())
        {
            bool exists = context.Directions.Any(d => d.direction_name.ToLower() == directionName.ToLower());

            if (exists)
            {
                return new ValidationResult(ErrorMessage ?? $"A direction with the name '{directionName}' already exists.");
            }
        }

        return ValidationResult.Success;
    }
    public UniqueDirectionNameAttribute(string errorMessage = "Name must be unique.") : base(errorMessage)
    {
    }
}