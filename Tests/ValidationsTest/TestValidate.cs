using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Yaba.Tools.Validations;

namespace Tests.ValidationsTest
{
    public class TestValidate
    {
        [Fact]
        public void Validate_NotNull()
        {
            Action act = () =>
            {
                object nullObject = null;
                Validate.NotNull(nullObject);
            };

            act.Should().Throw<ArgumentException>().WithMessage("Object cannot be null");
        }

        [Fact]
        public void Validate_NotNullWithCustomMessage()
        {
            Action act = () =>
            {
                object nullObject = null;
                Validate.NotNull(nullObject, "Custom message error");
            };

            act.Should().Throw<ArgumentException>().WithMessage("Custom message error");
        }

        [Fact]
        public void Validate_NotNullOrEmpty()
        {
            Action act = () =>
            {
                var nullObject = "";
                Validate.NotNullOrEmpty(nullObject);
            };

            act.Should().Throw<ArgumentException>().WithMessage("Text cannot be empty or null");
        }

        [Fact]
        public void Validate_NotNullOrEmptyWithCustomMessage()
        {
            Action act = () =>
            {
                string nullObject = null;
                Validate.NotNullOrEmpty(nullObject, "Custom message error");
            };

            act.Should().Throw<ArgumentException>().WithMessage("Custom message error");
        }

        [Fact]
        public void Validate_IsTrue()
        {
            Action act = () =>
            {
                var condition = 1 == 2;
                Validate.IsTrue(condition);
            };

            act.Should().Throw<ArgumentException>().WithMessage("Condition must be true");
        }

        [Fact]
        public void Validate_IsTrueWithCustomMessage()
        {
            Action act = () =>
            {
                var condition = 1 >= 3;
                Validate.IsTrue(condition, "Custom message error");
            };

            act.Should().Throw<ArgumentException>().WithMessage("Custom message error");
        }
    }
}
