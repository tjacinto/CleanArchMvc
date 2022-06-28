﻿using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Product : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }


        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidateDomain(name, description, price, stock, image);
        }

        public void UpdateProduct(string name, string description, decimal price, int stock, string image, int categoryId)
        {
            ValidateDomain(name, description, price, stock, image);
            CategoryId = categoryId;
        }

        public Product(int id, string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(id < 0 , "Invalid Id value.");
            Id = id;
            ValidateDomain(name, description, price, stock, image);
        }

        public void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name.Name is required.");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name.Name, too short, minimum 3 characters.");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalid name.Name is required.");
            DomainExceptionValidation.When(description.Length < 5, "Invalid description, too short, minimum 5 characters.");

            DomainExceptionValidation.When(price < 0, "Invalid price value.");

            DomainExceptionValidation.When(stock < 0, "Invalid price value.");

            DomainExceptionValidation.When(image.Length < 250, "Invalid image, too short, minimum 250 characters.");

            name = name;
            description = description;
            price = price;
            stock = stock;
            image = image;

        }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
