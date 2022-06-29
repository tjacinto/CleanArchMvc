﻿using CleanArchMvc.Domain.Validation;
using System.Collections.Generic;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Category : Entity
    {
        public Category(string name)
        {
            ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value.");
            Id = id;
            ValidateDomain(name);
        }

        public void UpdateCategory(string name)
        {
            ValidateDomain(name);
        }

        public ICollection<Category> Products { get; set; }
        public void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name.Name is required.");

            DomainExceptionValidation.When(name.Length < 3, "Invalid name.Name too short, minimum 3 characters.");

            Name = name;
        }
    }
}
