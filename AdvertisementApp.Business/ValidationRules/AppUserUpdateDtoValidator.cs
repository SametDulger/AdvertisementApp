﻿using AdvertisementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Business.ValidationRules
{
    public class AppUserUpdateDtoValidator : AbstractValidator<AppUserUpdateDto>
    {
        public AppUserUpdateDtoValidator()
        {

            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Firstname).NotEmpty();
            RuleFor(x => x.Surname).NotEmpty();
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.GenderId).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.PhoneNumber).NotEmpty();

        }
    }
}
