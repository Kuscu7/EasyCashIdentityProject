using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Alanı Boş Geçirilemez.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("En fazla 30 karakter girebilirsiniz.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("En az 2 karakter girebilirsiniz.");

            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyad Alanı Boş Geçilemez.");
            RuleFor(x => x.SurName).MaximumLength(30).WithMessage("En fazla 30 karakter girebilirsiniz.");
            RuleFor(x => x.SurName).MinimumLength(2).WithMessage("En az 2 karakter girebilirsiniz.");

            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez.");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen Geçerli bir mail adresi giriniz.");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez.");
            

            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Alanı Boş Geçilemez.");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Şifreleriniz Eşleşmiyor");




        }
    }
}
