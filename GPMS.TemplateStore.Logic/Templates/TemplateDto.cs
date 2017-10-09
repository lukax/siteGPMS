namespace GPMS.TemplateStore.Logic.Templates
{
    public class TemplateDto
    {
        public long Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string PreviewImageUrl { get; }
        public string ThumbnailImageUrl { get; }
        public string FileUrl { get; }
        public string FileType { get; }

        public TemplateDto(
            long id, 
            string name, 
            string description,
            string previewImageUrl,
            string thumbnailImageUrl,
            string fileUrl, 
            string fileType)
        {
            Id = id;
            Name = name;
            Description = description;
            PreviewImageUrl = previewImageUrl;
            ThumbnailImageUrl = thumbnailImageUrl;
            FileUrl = fileUrl;
            FileType = fileType;
        }

    }
}
