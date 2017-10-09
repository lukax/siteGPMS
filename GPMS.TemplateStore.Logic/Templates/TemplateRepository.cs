using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GPMS.TemplateStore.Logic.Common;
using GPMS.TemplateStore.Logic.Users;
using GPMS.TemplateStore.Logic.Utils;
using NHibernate;
using NHibernate.Linq;

namespace GPMS.TemplateStore.Logic.Templates
{
    public class TemplateRepository : Repository<Template>
    {
        public IReadOnlyList<TemplateDto> GetTemplateList(IUser user)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                return session.Query<Template>()
                    .ToList() // Fetch data into memory
                    .Select(x => new TemplateDto(x.Id, x.Name, x.Description, x.FileInfo.PreviewImgUrl, x.FileInfo.ThumbnailImgUrl, x.FileInfo.FileUrl, x.FileInfo.FileType))
                    .ToList();
            }
        }

    }
}
