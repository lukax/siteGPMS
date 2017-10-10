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
            new TemplateDto(1, "Plano de Projeto", @"O Plano de Gerenciamento de Configuração descreve todas as atividades do Gerenciamento de Controle
            de Configuração e Mudança que serão executadas durante o ciclo de vida do produto. Suas atividades
            envolvem identificar a configuração do software, manter sua integridade durante o projeto e controlar
            sistematicamente as mudanças.",  "/images/s-1.jpg", "/images/s-1.png", "", ".docx"),

            new TemplateDto(2, "Plano de Comunicação", @"O Plano de Gerenciamento de Configuração descreve todas as atividades do Gerenciamento de Controle
            de Configuração e Mudança que serão executadas durante o ciclo de vida do produto. Suas atividades
            envolvem identificar a configuração do software, manter sua integridade durante o projeto e controlar
            sistematicamente as mudanças.", "/images/p-2.jpg", "/images/p-2.png", "", ".docx"),

            new TemplateDto(3, "Plano de Riscos", @"O Plano de Gerenciamento de Configuração descreve todas as atividades do Gerenciamento de Controle
            de Configuração e Mudança que serão executadas durante o ciclo de vida do produto. Suas atividades
            envolvem identificar a configuração do software, manter sua integridade durante o projeto e controlar
            sistematicamente as mudanças.", "/images/p-3.jpg", "/images/p-3.png", "", ".docx"),

            new TemplateDto(4, "Plano de Testes", @"O Plano de Gerenciamento de Configuração descreve todas as atividades do Gerenciamento de Controle
            de Configuração e Mudança que serão executadas durante o ciclo de vida do produto. Suas atividades
            envolvem identificar a configuração do software, manter sua integridade durante o projeto e controlar
            sistematicamente as mudanças.", "/images/s-1.jpg", "/images/s-1.png", "", ".docx"),

            new TemplateDto(5, "Plano de Gerência de Comunicação", @"O Plano de Gerenciamento de Configuração descreve todas as atividades do Gerenciamento de Controle
            de Configuração e Mudança que serão executadas durante o ciclo de vida do produto. Suas atividades
            envolvem identificar a configuração do software, manter sua integridade durante o projeto e controlar
            sistematicamente as mudanças.", "/images/p-5.jpg", "/images/p-5.png", "", ".docx"),

            new TemplateDto(6, "Relatório de Encerramento de Projeto", @"O Plano de Gerenciamento de Configuração descreve todas as atividades do Gerenciamento de Controle
            de Configuração e Mudança que serão executadas durante o ciclo de vida do produto. Suas atividades
            envolvem identificar a configuração do software, manter sua integridade durante o projeto e controlar
            sistematicamente as mudanças.", "/images/p-6.jpg", "/images/p-6.png", "", ".docx"),
        };
    }
}