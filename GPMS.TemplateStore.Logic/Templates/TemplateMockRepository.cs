using System.Collections.Generic;
using System.Linq;
using GPMS.TemplateStore.Logic.Common;
using GPMS.TemplateStore.Logic.Users;
using GPMS.TemplateStore.Logic.Utils;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Util;

namespace GPMS.TemplateStore.Logic.Templates
{
    public class TemplateMockRepository
    {
        public IReadOnlyList<TemplateDto> GetTemplateList(IUser user)
            => Templates;

        public TemplateDto GetById(long id)
        {
            return Templates.FirstOrDefault(x => x.Id == id);
        }

        private IReadOnlyList<TemplateDto> Templates => new List<TemplateDto>
        {
            new TemplateDto(1, "Plano de Projeto", "TODO DESCRIPTION", "/images/s-1.jpg", "/images/s-1.png", "", ""),
            new TemplateDto(2, "Plano de Comunicação", "TODO DESCRIPTION", "/images/p-2.jpg", "/images/p-2.png", "", ""),
            new TemplateDto(3, "Plano de Riscos", "TODO DESCRIPTION", "/images/p-3.jpg", "/images/p-3.png", "", ""),
            new TemplateDto(4, "Plano de Testes", "TODO DESCRIPTION", "/images/s-1.jpg", "/images/s-1.png", "", ""),
            new TemplateDto(5, "Plano de Gerência de Comunicação", "TODO DESCRIPTION", "/images/p-5.jpg", "/images/p-5.png", "", ""),
            new TemplateDto(6, "Relatório de Encerramento de Projeto", "TODO DESCRIPTION", "/images/p-6.jpg", "/images/p-6.png", "", ""),
        };
    }
}