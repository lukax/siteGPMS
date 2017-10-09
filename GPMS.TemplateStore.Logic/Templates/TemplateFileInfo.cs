using System;
using GPMS.TemplateStore.Logic.Common;

namespace GPMS.TemplateStore.Logic.Templates
{
    public class TemplateFileInfo : ValueObject<TemplateFileInfo>
    {
        public string PreviewImgUrl { get; set; }
        public string ThumbnailImgUrl { get; set; }
        public string FileUrl { get; set; }

        public string FileType { get; set; }
        public DateTime UploadedOn { get; set; }
        public int DownloadCount { get; set; }

        protected override bool EqualsCore(TemplateFileInfo other)
        {
            throw new NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}