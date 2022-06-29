using CleanArchMvc.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact(DisplayName = "Create Product With Valid State")]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            //ARRANGE
            var name = "IPhone X";
            var description = "128 GB RAM";
            var price = 3000;
            var stock = 10;
            string image = "url imagem";

            //ACT
            Action action = () => new Product(name, description, price, stock, image);

            //ASSERT
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_NegativeIdValue_DomainExceptionInvalidId()
        {
            //ARRANGE
            var id = -10;
            var name = "IPhone X";
            var description = "128 GB RAM";
            var price = 3000;
            var stock = 10;
            string image = "url imagem";

            //ACT
            Action action = () => new Product(id, name, description, price, stock, image);

            //ASSERT
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id value.");
        }

        [Fact]
        public void CreateProduct_MissingNameValue_DomainExceptionRequiredName()
        {
            //ARRANGE
            var id = 10;
            var name = "";
            var description = "128 GB RAM";
            var price = 3000;
            var stock = 10;
            string image = "url imagem";

            //ACT
            Action action = () => new Product(id, name, description, price, stock, image);

            //ASSERT
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name.Name is required.");
        }

        [Fact]
        public void CreateProduct_ShortNameValue_DomainExceptionShortName()
        {
            //ARRANGE
            var id = 10;
            var name = "IP";
            var description = "128 GB RAM";
            var price = 3000;
            var stock = 10;
            string image = "url imagem";

            //ACT
            Action action = () => new Product(id, name, description, price, stock, image);

            //ASSERT
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name.Name, too short, minimum 3 characters.");
        }

        [Fact]
        public void CreateProduct_WithNullNameValue_DomainExceptionRequiredName()
        {
            //ARRANGE
            var id = 10;
            var description = "128 GB RAM";
            var price = 3000;
            var stock = 10;
            string image = "url imagem";

            //ACT
            Action action = () => new Product(id, null, description, price, stock, image);

            //ASSERT
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_MissingDescriptionValue_DomainExceptionRequiredDescription()
        {
            //ARRANGE
            var id = 10;
            var name = "IPhone 11";
            var description = "";
            var price = 3000;
            var stock = 10;
            string image = "url imagem";

            //ACT
            Action action = () => new Product(id, name, description, price, stock, image);

            //ASSERT
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description.Description is required.");
        }

        [Fact]
        public void CreateProduct_ShortDescriptionValue_DomainExceptionShortDescription()
        {
            //ARRANGE
            var id = 10;
            var name = "Iphone 11";
            var description = "128";
            var price = 3000;
            var stock = 10;
            string image = "url imagem";

            //ACT
            Action action = () => new Product(id, name, description, price, stock, image);

            //ASSERT
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description.Description, too short, minimum 5 characters.");
        }

        [Fact]
        public void CreateProduct_WithNullDescriptionValue_DomainExceptionDescriptionRequired()
        {
            //ARRANGE
            var id = 10;
            var name = "Iphone 11";
            var price = 3000;
            var stock = 10;
            string image = "url imagem";

            //ACT
            Action action = () => new Product(id, name, null, price, stock, image);

            //ASSERT
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_NegativePriceValue_DomainExceptionInvalidPrice()
        {
            //ARRANGE
            var id = 10;
            var name = "Iphone 11";
            var description = "128 GB RAM";
            var price = -3000;
            var stock = 10;
            string image = "url imagem";

            //ACT
            Action action = () => new Product(id, name, description, price, stock, image);

            //ASSERT
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid price value.");
        }

        [Fact]
        public void CreateProduct_MissingPriceValue_DomainExceptionInvalidPrice()
        {
            //ARRANGE
            var id = 10;
            var name = "Iphone 11";
            var description = "128 GB RAM";
            var price = 0;
            var stock = 10;
            string image = "url imagem";

            //ACT
            Action action = () => new Product(id, name, description, price, stock, image);

            //ASSERT
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid price value.");
        }

        [Fact]
        public void CreateProduct_NegativeStockValue_DomainExceptionInvalidStock()
        {
            //ARRANGE
            var id = 10;
            var name = "Iphone 11";
            var description = "128 GB RAM";
            var price = 3000;
            var stock = -10;
            string image = "url imagem";

            //ACT
            Action action = () => new Product(id, name, description, price, stock, image);

            //ASSERT
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid stock value.");
        }

        [Fact]
        public void CreateProduct_LongImageValue_DomainExceptionInvalidImage()
        {
            //ARRANGE
            var id = 10;
            var name = "Iphone 11";
            var description = "128 GB RAM";
            var price = 3000;
            var stock = 10;
            string image = "URL IMAGEM EXTENSA URL IMAGEM EXTENSA URL IMAGEM EXTENSA URL IMAGEM EXTENSA URL IMAGEM EXTENSA URL IMAGEM EXTENSA URL IMAGEM EXTENSA URL IMAGEM EXTENSA URL IMAGEM EXTENSA URL IMAGEM EXTENSA URL IMAGEM EXTENSA URL IMAGEM EXTENSA URL IMAGEM EXTENSA URL IMAGEM EXTENSA URL IMAGEM EXTENSA URL IMAGEM EXTENSA";

            //ACT
            Action action = () => new Product(id, name, description, price, stock, image);

            //ASSERT
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid image, too long, maximum 250 characters.");
        }

        [Fact]
        public void CreateProduct_WithNullImageValue_NoDomainException()
        {
            //ARRANGE
            var id = 10;
            var name = "Iphone 11";
            var description = "128 GB RAM";
            var price = 3000;
            var stock = 10;

            //ACT
            Action action = () => new Product(id, name, description, price, stock, null);

            //ASSERT
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_WithNullImageValue_NoNullReferenceException()
        {
            //ARRANGE
            var id = 10;
            var name = "Iphone 11";
            var description = "128 GB RAM";
            var price = 3000;
            var stock = 10;

            //ACT
            Action action = () => new Product(id, name, description, price, stock, null);

            //ASSERT
            action.Should()
                .NotThrow<NullReferenceException>();
        }
    }
}
