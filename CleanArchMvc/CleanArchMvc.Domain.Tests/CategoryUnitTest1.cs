using CleanArchMvc.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace CleanArchMvc.Domain.Tests
{
    public class CategoryUnitTest1
    {
        [Fact(DisplayName = "Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            //ARRANGE
            var id = 1;
            var nameCategory = "Smartphones";

            //ACT
            Action action = () => new Category(id, nameCategory);

            //ASSERT
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateCategory_NegativeIdValue_DomainExceptionInvalidId()
        {
            //ARRANGE
            var id = -10;
            var nameCategory = "Smartphones";

            //ACT
            Action action = () => new Category(id, nameCategory);

            //ASSERT
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id value.");
        }

        [Fact]
        public void CreateCategory_MissingNameValue_DomainExceptionRequiredName()
        {
            //ARRANGE
            var id = 10;
            var nameCategory = "";

            //ACT
            Action action = () => new Category(id, nameCategory);

            //ASSERT
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name.Name is required.");
        }

        [Fact]
        public void CreateCategory_ShortNameValue_DomainExceptionShortName()
        {
            //ARRANGE
            var id = 10;
            var nameCategory = "UP";

            //ACT
            Action action = () => new Category(id, nameCategory);

            //ASSERT
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name.Name too short, minimum 3 characters.");
        }

        [Fact]
        public void CreateCategory_WithNullNameValue_DomainExceptionShortName()
        {
            //ARRANGE
            var id = 10;

            //ACT
            Action action = () => new Category(id, null);

            //ASSERT
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }
    }
}
