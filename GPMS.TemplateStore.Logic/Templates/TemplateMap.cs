using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;

namespace GPMS.TemplateStore.Logic.Templates
{
    public class TemplateMap : ClassMap<Template>
    {
        public TemplateMap()
        {
            Id(x => x.Id);

            Map(x => x.Name);
            Map(x => x.Description);

            Component(x => x.File, y =>
            {
                y.Map(x => x.DownloadCount);
                y.Map(x => x.Type);
                y.Map(x => x.UploadedOn);
                y.Map(x => x.Url);
            });
        }
    }
}
