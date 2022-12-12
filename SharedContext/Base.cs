using Balta.NoticationContext;

namespace Balta.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
             Id = Guid.NewGuid();
        }
         public Guid Id {get; set; }
    }
}