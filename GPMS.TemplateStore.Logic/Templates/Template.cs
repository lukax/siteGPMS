using GPMS.TemplateStore.Logic.Common;

namespace GPMS.TemplateStore.Logic.Templates
{
    public class Template : AggregateRoot
    {
        public virtual string Name { get; protected set; }
        public virtual string Description { get; protected set; }

        public TemplateFile File { get; protected set; }

        public Template()
        {

        }

    }
}
