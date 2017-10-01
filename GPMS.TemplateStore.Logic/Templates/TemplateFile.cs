using System;
using GPMS.TemplateStore.Logic.Common;

namespace GPMS.TemplateStore.Logic.Templates
{
    public class TemplateFile : ValueObject<TemplateFile>
    {
        public string Url { get; set; }
        public string Type { get; set; }
        public DateTime UploadedOn { get; set; }
        public int DownloadCount { get; set; }

        protected override bool EqualsCore(TemplateFile other)
        {
            throw new NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}