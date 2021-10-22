using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad soyad boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız");
            RuleFor(x => x.WriterPassword).Length(1, 20).Matches(@"[A-Z]+").WithMessage("Şifreniz en az bir büyük karakter içermelidir.");
            RuleFor(x => x.WriterPassword).Length(1, 20).Matches(@"[a-z]+").WithMessage("Şifreniz en az bir küçük karakter içermelidir.");
            RuleFor(x => x.WriterPassword).Length(1, 20).Matches(@"[0-9]+").WithMessage("Şifreniz en az bir rakam içermelidir.");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz");
        }
    }
}
