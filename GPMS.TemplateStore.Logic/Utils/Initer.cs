using GPMS.TemplateStore.Logic.Common;

namespace GPMS.TemplateStore.Logic.Utils
{
    public static class Initer
    {
        public static void Init(string connectionString)
        {
            SessionFactory.Init(connectionString);
            DomainEvents.Init();
        }
    }
}
